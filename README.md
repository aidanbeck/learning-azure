# learning-azure
Learning Azure Function Apps

## Deployed Azure Functions
* [Visitor Counter API](https://trailbound-e2fma9b7avb2brav.centralus-01.azurewebsites.net/api/helloWorld2): Initial Durable Function experiment
* [JavaScript Function](https://javascriptfunctions-dbhubef0aydvccdk.centralus-01.azurewebsites.net/api/MyPracticeFunction): Node.js HTTP-trigger example
* [C# Function](https://csharpfunctions-aka5fvdneagebrb6.centralus-01.azurewebsites.net/api/MyPracticeFunction): .NET isolated HTTP-trigger example

## Github Codespaces Workflow
Notes for Initalization and Deployment for Azure Functions within Codespaces.
A traditional environment such as Visual Studio Code will be better, and I will transition to it.

### Initialization
* npm install -g azure-functions-core-tools@4 --unsafe-perm true
* func init MyFunctionApp (Choose Language)
* cd MyFunctionApp
* func new (Choose HttpTrigger)
* dotnet run

### Deployment
* Create Function App in Azure Portal.
* File > Open Folder > Open Project Folder
* Command Palette > Azure Functions: Deploy Function App
* Choose Function App to overwrite