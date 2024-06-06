using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SmartBot.DataDto.Base;
using SmartBot.Services.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SmartBot.Api.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            // lúc đăng kí
            _next = next;
            _appSettings = appSettings.Value;
        }

        private void attachUserToContext(HttpContext context, IUserService userService, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                string userId = jwtToken.Claims.First(x => x.Type == "id").Value;
                context.Items["user"] = userService.getUserById(int.Parse(userId));
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }
        }

        public async Task Invoke(HttpContext context, IUserService userService)
        {
            // mỗi request sau này nhảy vào đây tiền xử lý
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                attachUserToContext(context, userService, token);
            }
            await _next(context);
        }
    }
}
