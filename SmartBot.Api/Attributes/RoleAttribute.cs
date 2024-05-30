using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SmartBot.Api.Providers;
using SmartBot.Common.Enums;
using SmartBot.Services.Roles;
using System.IdentityModel.Tokens.Jwt;

namespace SmartBot.Api.Attributes
{
    public class RoleAttribute : Attribute, IActionFilter
    {
        public Role[] Roles { get; set; }

        public RoleAttribute(params Role[] roles)
        {
            Roles = roles;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // không thể khởi tạo service thông qua contructor như bình thường 
            // phải tạo ra 1 cái là provider, đây là 1 cách để lấy service đã được khởi tạo ra dùng

            var httpContext = (IHttpContextAccessor?)StaticServiceProvider.Provider.GetService(typeof(IHttpContextAccessor));
            var authorityService = (IRoleService?)httpContext?.HttpContext?.RequestServices.GetService(typeof(IRoleService));
            // lấy token
            Microsoft.Extensions.Primitives.StringValues authTokens;
            context.HttpContext.Request.Headers.TryGetValue("Authorization", out authTokens);
            var _token = authTokens.FirstOrDefault()?.Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_token);
            string? UserId = jwtSecurityToken?.Claims.FirstOrDefault(x => x.Type == "id")?.Value;
            int userId = int.Parse(UserId == null ? "" : UserId);
            var isChecked = authorityService?.CheckUserRole(Roles, userId);
            if (isChecked == null)
            {
                context.Result = new JsonResult("NoPermission")
                {
                    StatusCode = 500,
                    Value = new
                    {
                        Status = "Error",
                        Message = "Something wrong when check role"
                    },
                };
            }
            else if (isChecked == false)
            {
                context.Result = new JsonResult("NoPermission")
                {
                    StatusCode = 403,
                    Value = new
                    {
                        Status = "Error",
                        Message = "Sorry, You don't have permission for the action."
                    },
                };
            }
        }
    }
}
