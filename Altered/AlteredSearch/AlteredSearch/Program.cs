using AlteredSearch.Helpers;
using AlteredSearch.EndPoints;
using AlteredSearch.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços do Swagger (NSwag)
builder.Services.AddEndpointsApiExplorer(); // opcional com NSwag, mas não atrapalha
builder.Services.AddOpenApiDocument(config =>
{
    config.Title = "Altered API SearchText";
});

// Adiciona o factory
builder.Services.AddScoped<IApiAlteredService, ApiAlteredService>();

builder.ConfigureRefit();

var app = builder.Build();

app.AddOpenApiServices();

app.UseHttpsRedirection();

app.RegisterEndpoints();

app.Run();
