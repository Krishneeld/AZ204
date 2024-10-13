using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AZ204.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private static readonly string[] CarModels = new[] { "Toyota Camry", "Honda Civic", "Ford Mustang", "Chevrolet Malibu", "Tesla Model 3", "BMW 3 Series", "Audi A4", "Mercedes-Benz C-Class", "Nissan Altima" };

        public CarController()
        {

        }

        [HttpGet]
        [Route("GetCar")]
        public async Task<IActionResult> GetCar()
        {
            var random = new Random();
            int index = random.Next(CarModels.Length);
            string randomCar = CarModels[index];
            return Ok(randomCar);
        }
    }
}
