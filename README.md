# learning-azure
Learning Azure Function Apps

## Command line setup (For Codespaces)
* npm install -g azure-functions-core-tools@4 --unsafe-perm true
* func init MyFunctionApp --worker-runtime dotnet-isolated
* cd MyFunctionApp
* func new (Choose HttpTrigger)
* dotnet run