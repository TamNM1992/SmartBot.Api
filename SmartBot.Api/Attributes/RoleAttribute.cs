using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using SmartBot.Api.Providers;
using System.IdentityModel.Tokens.Jwt;
using SmartBot.Common.Enums;
using SmartBot.Services.Roles;

namespace SmartBot.Api.Attributes
{
    public class RoleAttribute : Attribute, IActionFilter
    {
        public role[] Roles { get; set; }
        public RoleAttribute(params role[] roles)
        {
            Roles = roles;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // không thể khởi tạo service thông qua contructor như bình thường 
            // phải tạo ra 1 cái là provider, đây là 1 cách để lấy service đã được khởi tạo ra dùng

            var httpContext = (IHttpContextAccessor)StaticServiceProvider.Provider.GetService(typeof(IHttpContextAccessor));
            var authorityService = (IRoleService)httpContext.HttpContext.RequestServices.GetService(typeof(IRoleService));

            // lấy token
            Microsoft.Extensions.Primitives.StringValues authTokens;
            context.HttpContext.Request.Headers.TryGetValue("Authorization", out authTokens);
            var _token = authTokens.FirstOrDefault().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_token);
            var idUser = int.Parse(jwtSecurityToken.Claims.First(x => x.Type == "nameid").Value);

            var isCheked = authorityService.CheckUserRole(Roles, idUser);

            if (!isCheked)
            {
                context.Result = new JsonResult("NoPermission")
                {
                    StatusCode = 403,
                    Value = new
                    {
                        Status = "Error",
                        Message = "Sorry, You don't have permission for the acction."
                    },
                };
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }
    }
}
