using Azure.Identity;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;


if(env.IsDevelopment()) //  for connecting to App Configuration locally - uses connection string
{
    builder.Configuration.AddAzureAppConfiguration(builder.Configuration["appConfigurationConnectionString"]);
}
else if (env.IsProduction())   //  for connecting to App Configuration from App service on Azure - uses Identity
{
    builder.Configuration.AddAzureAppConfiguration(options =>
            options.Connect(new Uri(builder.Configuration["appConfigEndpoint"]), new ManagedIdentityCredential()));
}


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);   // to access config in controllers
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
