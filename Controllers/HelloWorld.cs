using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
    [ApiController]
    [Route("api/helloworld")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
    }
}
