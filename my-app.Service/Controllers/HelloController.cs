using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public IActionResult GetHello()
        {
            var value = System.Environment.GetEnvironmentVariable("ENDPOINT_URL");
            Console.WriteLine(value);
            return Ok(value);
        }
    }
}
