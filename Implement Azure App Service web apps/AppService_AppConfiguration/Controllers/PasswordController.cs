using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AZ204.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        IConfiguration configuration;

        public PasswordController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("GetAppConfiguration")]
        public async Task<IActionResult> GetAppConfiguration()
        {
            string key = "dbuser";
            string pass = configuration[key]; // to read a key
            return Ok("Key: " + key + ", Value: " + pass);
        }
    }
}
