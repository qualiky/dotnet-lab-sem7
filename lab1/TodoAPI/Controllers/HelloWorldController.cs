using Microsoft.AspNetCore.Mvc;

namespace TodoAPI.Controllers{

    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello, World!";
        }
    }

}
