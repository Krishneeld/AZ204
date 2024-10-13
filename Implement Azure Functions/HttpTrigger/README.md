## Creating and publishing a Function App
- https://www.youtube.com/watch?v=kdRVComKwOc

#### Creating Function App in Azure:
- Go to Function App section and create a new one.
- Give a name to the app and fill in the rest of the details of the app.
- Under the deployment section of the creation process, ensure to turn on Basic Authentication.
- Once done, a storage account will also be needed as published code will be saved in the storage container.

#### Creating a Storage Account in Azure:
- Go to the storage account section and create a new one.
- Give a name and fill in the rest of the details.

#### Connecting Function App to storage Account:
- Open the storage account instance and go to Secutiy + Networking > Access keys.
- Copy the connection string, this will be configured in the function app.
- Open the function app instance and go to Settings > Environment variables.
- Under App settings, create a new setting.
- Name it "AzureWebJobsStorage". For the value, paste the connection string of the storage account.
- Apply all the changes.
- When the app is published to the function app, the code will be placed in that storage account.

#### Creating Function App in Visual Studio
- Create a new project in Visual Studio.
- For the type, select Azure Functions.
- Give a name to the project.
- For the function type, select HttpTrigger (for this example).

#### Publishing the sameple app to Azure Function App:
- Run the code and test it locally.
- Once done, select publish to open the publish profile.
- Login to Azure from Visual Studio and select the function app to which to publish to.
- Alternatively, you can download the publish profile of the Function App from Azure and use that to publish the app.
- Click publish to publish the app.
- Once published, open the app url in the browser.
- Go to https://<your-app-url>/api/<function-name>
- The sample response should appear.