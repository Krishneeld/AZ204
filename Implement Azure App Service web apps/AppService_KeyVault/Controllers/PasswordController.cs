using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebAppTest.Controllers
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
        [Route("GetPassword")]
        public async Task<IActionResult> GetPassword()
        {
            string key = "StorageConnStr";
            string pass = configuration[key]; // to read a key
            return Ok("Key: " + key + ", Pass: " + pass);
        }
    }
}
