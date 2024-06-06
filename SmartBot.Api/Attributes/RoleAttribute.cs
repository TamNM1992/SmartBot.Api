using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SmartBot.Api.Providers;
using SmartBot.Common.Enums;
using SmartBot.Services.Users.RoleServices;
using System.IdentityModel.Tokens.Jwt;

namespace SmartBot.Api.Attributes
{
    public class RoleAttribute : Attribute, IActionFilter
    {
        public Vips[] Roles { get; set; }

        public RoleAttribute(params Vips[] roles)
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

            var userId = int.Parse(jwtSecurityToken.Claims.First(x => x.Type == "nameid").Value);
            var isCheked = authorityService.IsUserHasRole(Roles, userId);

            if (!isCheked)
            {
                context.Result = new JsonResult("No Permission")
                {
                    StatusCode = 405,

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
