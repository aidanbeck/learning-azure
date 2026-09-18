using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFunctionApp;

public class HelloWorld
{
    private readonly ILogger<HelloWorld> _logger;

    public HelloWorld(ILogger<HelloWorld> logger)
    {
        _logger = logger;
    }

    [Function("GetUserInfo")] // define azure function
    public IActionResult GetUserInfo([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req) // "Run" can be anything. 
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Aidan Beck");
    }

    [Function("GetAllUsers")]
    public IActionResult GetAllUsers([HttpTrigger(AuthorizationLevel.Function, "get", Route = "users/getallusers")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Aidan Beck, Carter Beck");
    }

    [Function("GetExternalServiceURL")]
    public IActionResult GetExternalServiceURL([HttpTrigger(AuthorizationLevel.Function, "get", Route = "externalservice/getexternalserviceurl")] HttpRequest req)
    {
        var externalServiceUrl = Environment.GetEnvironmentVariable("SomeExternalService");
        return new OkObjectResult(externalServiceUrl);
    }

}
