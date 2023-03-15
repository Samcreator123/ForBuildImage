using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleAnswerController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "成功!";
        }
    }
}
