using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebAppTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreeController : ControllerBase
    {
        private static readonly string[] Trees = new[]
        {
            "Oak",
            "Pine",
            "Maple",
            "Birch",
            "Cedar",
            "Willow",
            "Redwood",
            "Spruce",
            "Cherry Blossom"
        };

        public TreeController()
        {

        }

        [HttpGet]
        [Route("GetTree")]
        public async Task<IActionResult> GetTree()
        {
            var random = new Random();
            int index = random.Next(Trees.Length);
            string randomTree = Trees[index];
            return Ok(randomTree);
        }
    }
}
