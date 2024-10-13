using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AZ204.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        private static readonly string[] Fish = new[]
        {
            "Salmon",
            "Tuna",
            "Clownfish",
            "Goldfish",
            "Betta",
            "Catfish",
            "Mackerel",
            "Swordfish",
            "Guppy"
        };

        public FishController()
        {

        }

        [HttpGet]
        [Route("GetFish")]
        public async Task<IActionResult> GetFish()
        {
            var random = new Random();
            int index = random.Next(Fish.Length);
            string randomFish = Fish[index];
            return Ok(randomFish);
        }
    }
}
