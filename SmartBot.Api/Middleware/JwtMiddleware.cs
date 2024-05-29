using Microsoft.IdentityModel.Tokens;
using SmartBot.Services.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SmartBot.Api.Middleware
{
    public class JwtMiddleware
    {

        private readonly RequestDelegate _next;
        // private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;
        public JwtMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
        {
            // lúc đăng kí
            _next = next;
            //_userService = userService;
            _serviceProvider = serviceProvider;
        }

        private void attachUserToContext(HttpContext context, string token)
        {
            try
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();
                IConfigurationRoot config = builder.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
                IConfigurationSection JWT = config.GetSection("Jwt");
                string? key = JWT["Key"];
                if (key != null)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var keyBytes = Encoding.ASCII.GetBytes(key);
                    tokenHandler.ValidateToken(token, new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                        ClockSkew = TimeSpan.Zero
                    }, out SecurityToken validatedToken);

                    var jwtToken = (JwtSecurityToken)validatedToken;
                    string userId = jwtToken.Claims.First(x => x.Type == "id").Value;
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        // lấy dịch vụ IUserService bằng provider
                        var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
                        // attach user to context on successful jwt validation
                        context.Items["user"] = userService.getUserById(int.Parse(userId));
                    }

                }
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }
        }

        public async Task Invoke(HttpContext context)
        {
            // mỗi request sau này nhảy vào đây tiền xử lý
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                attachUserToContext(context, token);
            }
            await _next(context);
        }
    }
}
