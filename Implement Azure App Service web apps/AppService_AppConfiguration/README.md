## Connecting App Service to App Configuration
- https://www.youtube.com/watch?v=t6m13DxUJMc
- https://learn.microsoft.com/en-us/azure/azure-app-configuration/quickstart-aspnet-core-app
- https://learn.microsoft.com/en-us/azure/azure-app-configuration/howto-integrate-azure-managed-service-identity?pivots=framework-dotnet#code-try-2

#### Packages required for App Configuration access:
- Microsoft.Extensions.Configuration.AzureAppConfiguration

#### Creating App Configuration in Azure:
- Go to App Configuration section and create a new one.
- Under Operations > Configuration explorer, Create new Key-value keys.
- Do not put labels in the key-value pairs to start with as it might not appear in the C# app.

#### Connecting to App Configuration in Azure (Development):
- In App Configuration instance, go to Settings > Access settings and copy the Connection string.
- Use this URI to connect to the App Configuration in the AddAzureAppConfiguration config builder in Program.cs.

#### Connecting to App Configuration in Azure (Production):
- Go to the App Service instance > Settings > Identity > System Assigned. Turn status to On and save.
- Go to App Configuration instance > Access control (IAM) > + Add > Add role assignment.
- Search for "App Configuration Data Reader" role > Next.
- On the Members page, select Managed identity.
- Then select "+ Select members" and select the App Service instance.
- Get the endpoint of the App Configuration instance to add to the appsettings file.
- Update the Program.cs to include the AddAzureAppConfiguration and ManagedIdentityCredential.
