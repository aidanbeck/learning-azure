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

    [Function("ExampleFunction")]
    public IActionResult ExampleFunction([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("This is a C# Function.");
    }

    [Function("CustomRoute")]
    public IActionResult CustomRoute([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "my/custom/route")] HttpRequest req)
    {
        return new OkObjectResult("This is a custom route!");
    }

    [Function("GetMyWebsiteURL")]
    public IActionResult GetMyWebsiteURL([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        /*
            Grab Environment Variable.
            When running local, this takes from local.settings.json which does not get deployed.
            Instead, you must recreate the environment variable in the Azure Portal as well.
            Function App > Settings > Environment Variables > Add.
        */
        var url = Environment.GetEnvironmentVariable("MyWebsiteURL");
        return new OkObjectResult(url);
    }

}