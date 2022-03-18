using Microsoft.AspNetCore.Mvc;

namespace SampleWebApiAspNetCore.v2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FoodsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var shivaji = null;
            shivaji = 10;
            
            return Ok("2.0");
        }
    }
}
