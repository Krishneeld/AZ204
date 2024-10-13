using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AZ204.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private static readonly string[] Animals = new[]
        {
            "Lion",
            "Elephant",
            "Giraffe",
            "Tiger",
            "Kangaroo",
            "Penguin",
            "Dolphin",
            "Panda",
            "Eagle"
        };

        public AnimalController()
        {

        }

        [HttpGet]
        [Route("GetAnimal")]
        public async Task<IActionResult> GetAnimal()
        {
            var random = new Random();
            int index = random.Next(Animals.Length);
            string randomAnimal = Animals[index];
            return Ok(randomAnimal);
        }
    }
}
