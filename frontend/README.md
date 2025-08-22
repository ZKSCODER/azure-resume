# Frontend (Website)

This folder contains the static website for the Azure Resume project.

## Structure
- `index.html`: Main resume page
- `main.js`: Handles visitor counter logic
- `css/`, `images/`, `js/`: Assets and scripts

## How the Visitor Counter Works
- On page load, `main.js` sends a request to the Azure Function API.
- The API increments and returns the visitor count from CosmosDB.
- The count is displayed on the website.

## Setup
1. Update `main.js` with your Azure Function endpoint URL.
2. Open `index.html` in your browser to test locally.

## Deployment
- Host the frontend on Azure Storage (Static Website), GitHub Pages, or any static hosting provider.
- Ensure CORS is configured to allow requests from your frontend to the backend API.

## Troubleshooting
- If the visitor counter does not update, check the browser console for errors.
- Ensure the backend API is deployed and accessible from the frontend.
- Verify CORS settings on your Azure Function App.

---
For backend setup, see the README in the `backend` folder.
