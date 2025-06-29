using AlteredSearch.Middlewares;
using Microsoft.AspNetCore.Builder;
using NSwag;
using NSwag.AspNetCore;
using NSwag.Generation.Processors.Security;

namespace AlteredSearch.Helpers;

public static class ConfigureApi
{
    public static IServiceCollection ConfigureApiServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();

        services.AddOpenApiDocument(config =>
        {
            config.Title = "AlteredSearch API";
            config.Version = "v1";
            config.Description = "API para consultar dados públicos do jogo Altered.";
            config.AddSecurity("Bearer", [], new OpenApiSecurityScheme
            {
                Type = OpenApiSecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = OpenApiSecurityApiKeyLocation.Header,
                Name = "Authorization",
                Description = "Insira o token JWT no formato: Bearer {seu_token}"
            });

            config.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("Bearer"));
        });

        return services;
    }

    public static WebApplication ConfigureApiPipeline(this WebApplication app)
    {
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        app.UseOpenApi();      // Gera o /swagger/v1/swagger.json
        app.UseSwaggerUi();   // Interface Swagger compatível com WithDescription

        return app;
    }
}
