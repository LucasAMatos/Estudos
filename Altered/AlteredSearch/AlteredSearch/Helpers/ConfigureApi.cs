namespace AlteredSearch.Helpers;

internal static class ConfigureApi
{
    public static WebApplication AddOpenApiServices(this WebApplication api)
    {
        // Middleware do Swagger
        if (api.Environment.IsDevelopment())
        {
            api.UseOpenApi();      // Serve o /swagger/v1/swagger.json
            api.UseSwaggerUi();   // Interface gráfica do Swagger
        }

        return api;
    }
}
