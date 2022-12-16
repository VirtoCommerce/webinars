using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VirtoCommerce.MyLoyalty.Core;

namespace VirtoCommerce.MyLoyalty.Web.Controllers.Api
{
    [Route("api/my-loyalty")]
    public class MyLoyaltyController : Controller
    {
        // GET: api/my-loyalty
        /// <summary>
        /// Get message
        /// </summary>
        /// <remarks>Return "Hello world!" message</remarks>
        [HttpGet]
        [Route("")]
        [Authorize(ModuleConstants.Security.Permissions.Read)]
        public ActionResult<string> Get()
        {
            return Ok(new { result = "Hello world!" });
        }
    }
}
