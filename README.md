# Azure Resume
My own Azure Resume project, following [ACG project video](https://www.youtube.com/watch?v=ieYrBWmkfno).

## Project Overview
This project consists of:
- **Frontend**: Static website displaying your resume and visitor counter.
- **Backend**: Azure Function API that increments and returns the visitor count from CosmosDB.

## Prerequisites
- Azure account
- .NET 8 SDK
- Azure Functions Core Tools
- CosmosDB instance

## Setup
### Backend
1. Navigate to `backend/api` and install dependencies:
	```sh
	dotnet restore
	```
2. Update `local.settings.json` with your CosmosDB connection string.
3. Build and run locally:
	```sh
	dotnet build
	func start
	```

### Frontend
1. Update `main.js` with your Azure Function endpoint URL.
2. Open `index.html` in your browser to test locally.

## Deployment
### Backend
1. Deploy to Azure using Azure CLI or VS Code.

### Frontend
- Host on Azure Storage (Static Website), GitHub Pages, or any static hosting provider.
- Configure CORS to allow requests from your frontend to the backend API.

## Troubleshooting
- Ensure output bindings in the backend are on properties or return types, not method parameters.
- Make sure your Azure Function App is set to .NET 8 Isolated Worker.
- Check Azure portal logs for deployment errors.
- Verify all required NuGet packages are installed in `api.csproj`
- Verify Azure Core Tools is up to date

---
For more details, see the README files in the `backend` and `frontend` folders.

