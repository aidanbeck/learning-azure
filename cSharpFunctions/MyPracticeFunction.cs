using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cSharpFunctions;

public class MyPracticeFunction
{
    private readonly ILogger<MyPracticeFunction> _logger;

    public MyPracticeFunction(ILogger<MyPracticeFunction> logger)
    {
        _logger = logger;
    }

    [Function("MyPracticeFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("This is a C# Function.");
    }
}
