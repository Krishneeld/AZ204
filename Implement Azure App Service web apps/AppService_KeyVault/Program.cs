using Azure.Identity;
using Microsoft.Extensions.Configuration;
var builder = WebApplication.CreateBuilder(args);

// get Key Vault URI from appsettings. this can go in environment variable
var keyVaultEndpoint = new Uri(builder.Configuration["keyVaultUrl"]);
builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
