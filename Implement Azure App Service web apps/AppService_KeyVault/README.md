## Connecting App Service to Key Vault
- https://www.youtube.com/watch?v=QIXbyInGXd8

#### Packages required for KeyVault access:
- Azure.Extensions.AspNetCore.Configuration.Secrets
- Azure.Identity
- Azure.Security.KeyVault.Secrets

#### Creating Key Vault in Azure:
- Go to Key Vault section and create a new one. For the Permission model, this demo uses Vault access policy.
- Add some secrets in the Objects > Secrets section

#### Conneting to Key Vault:
- Right click on the Project name > Overview > Connected Services
- Click the + button to add new dependency
- Add Azure Key Vault
- You must also sign in with the account that has access to read the key vault.

#### Connecting from Visual Studio to Key Vault (Development)
- Go to the App Service instance > Overview and copy the Vault URI.
- Use this URI to connect to the key vault in the AddAzureKeyVault config builder in Program.cs.

#### Troubleshooting:
- If it doesnt connect, you might have to look at the RBAC roles the user has
- If you are the owner/admin of the Key Vault you will be able to access it from Visual Studio while signed in.
- If some other developer is accessing it, you might have to assign them role to access the key vault.

#### Connecting from App Service to Key Vault (Production)
- Go to the App Service instance > Settings > Identity > System Assigned. Turn status to On and save.
- Go to the Key Vault > Create new access policy > select Get and List for all 3 options.
- For the principal, select your app service, then create.
- Restart the App Service.

## Deploying code to App Service from GitHub using CLI
Deploying from CLI can be done using the following steps:
- Create necessary variables\
	`gitrepo = https://github.com/Contoso/webapp`\
	`webappname = businesswebapp`\
	`resourcegroupname = BusinessAppResourceGroup`
- Create resource group\
	`az group create --location centralus --name $resourcegroupname`
- Create app service plan\
	`az appservice plan create --name $webappname --resource-group $resourcegroupname --sku S3`
- Create the web app\
	`az webapp create --name $webappname --resource-group $resourcegroupname`
- Optionally create the deployment slot\
	`az webapp deployment slot create --name $webappname --resource-group $resourcegroupname --slot staging`
- Link the GitHub repo to the app service instance\
	`az webapp deployment source config --name $webappname --resource-group $resourcegroupname --slot staging --repo-url $gitrepo --branch master --manual-integration`
