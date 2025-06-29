using AlteredSearch.Helpers;
using AlteredSearch.EndPoints;
using AlteredSearch.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureApiServices();

// Adiciona o factory
builder.Services.AddScoped<IApiAlteredService, ApiAlteredService>();

builder.ConfigureRefit();

var app = builder.Build();

app.ConfigureApiPipeline();

app.UseHttpsRedirection();

app.MapPersonagensEndpoints();

app.MapFactionsEndpoints();

app.Run();
