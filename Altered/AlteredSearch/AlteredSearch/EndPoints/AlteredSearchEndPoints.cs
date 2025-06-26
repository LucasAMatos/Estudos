using AlteredSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlteredSearch.EndPoints;

internal static class AlteredSearchEndPoints
{
    internal static WebApplication RegisterEndpoints(this WebApplication api)
    {
        api.MapGet("/", () => Results.Redirect("/swagger"))
        .ExcludeFromDescription();

        api.MapGet("/personagens", async ([FromServices] IApiAlteredService api) =>
        {
            try
            {
                var result = await api.ListarTodosOsPersonagens();

                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"Erro: {ex.Message}");
            }
        });

        return api;
    }
}