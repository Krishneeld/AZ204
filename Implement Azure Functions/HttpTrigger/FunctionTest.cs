using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace HttpTrigger
{
    public class FunctionTest
    {
        private readonly ILogger<FunctionTest> _logger;

        public FunctionTest(ILogger<FunctionTest> logger)
        {
            _logger = logger;
        }

        [Function("FunctionTest")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
