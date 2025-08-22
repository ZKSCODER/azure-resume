# Backend (Azure Function API)

This folder contains the Azure Function backend for the Azure Resume project.

## Prerequisites
- Azure account
- .NET 8 SDK (Isolated Worker)
- Azure Functions Core Tools
- CosmosDB instance

## Setup
1. Navigate to `api` and install dependencies:
   ```sh
   dotnet restore
   ```
2. Update `local.settings.json` with your CosmosDB connection string:
   ```json
   {
     "IsEncrypted": false,
     "Values": {
       "AzureWebJobsStorage": "UseDevelopmentStorage=true",
       "AzureResumeConnectionString": "<your-cosmosdb-connection-string>"
     }
   }
   ```
3. Build and run locally:
   ```sh
   dotnet build
   func start
   ```

## Deployment
1. Deploy to Azure using Azure CLI or VS Code.

## Function Details
- **GetResumeCounter**: Increments and returns the visitor counter from CosmosDB.
- Output binding must be on a property or return type (not a method parameter).

## Troubleshooting
- Ensure your Azure Function App is set to .NET 8 Isolated Worker.
- Check Azure portal logs for deployment errors.
- Verify all required NuGet packages are installed in `api.csproj`.
- Output bindings must be on properties or return types, not method parameters.

---
For more details, see the main README in the project root.
