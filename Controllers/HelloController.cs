using Microsoft.AspNetCore.Mvc;

namespace WebApiWithoutAws.Controllers
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Get()
        {
            var message = Environment.GetEnvironmentVariable("MY_MESSAGE")
                          ?? "Hello from default!";
            var name = Environment.GetEnvironmentVariable("MY_NAME")
                       ?? "Default Name";
            return Ok(new { Message = message, Name = name });
        }
    }

}
