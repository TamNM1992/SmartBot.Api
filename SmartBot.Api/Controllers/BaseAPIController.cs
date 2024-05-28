using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SmartBot.Api.Controllers
{
    public class BaseAPIController : ControllerBase
    {
        private Claim? getClaim(string type)
        {
            return User.Claims.Where(c => c.Type == type).FirstOrDefault();
        }

        internal string? getUserId()
        {
            Claim? claim = getClaim("id");
            return claim == null ? null : claim.Value;
        }
    }
}
