using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace SmartBot.Common.Helpers
{
    public static class Token
    {
        public static string GenerateSecurityToken(int userId, string day)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("123456789abcdefghijklmnopqrstuvwxyz");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                 {
                      new Claim(ClaimTypes.NameIdentifier, userId.ToString())
                 }),
                Expires = DateTime.UtcNow.AddDays(double.Parse(day)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                //Audience = "https://nhatkyhoctap.blogspot.com",
                Issuer = "SmartbotApi"
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }
        public static string Authentication(string token)
        {
            var secret = "123456789abcdefghijklmnopqrstuvwxyz";

            var key = Encoding.ASCII.GetBytes(secret);
            var tokenHandler = new JwtSecurityTokenHandler();

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
            var username = jwtToken.Claims.FirstOrDefault(x => x.Type=="nameid").Value;
            //var userId = Guid.Parse(jwtToken.Claims.FirstOrDefault(x=>x.Type=="nameid").Value);

            return username;
        }

    }
}
