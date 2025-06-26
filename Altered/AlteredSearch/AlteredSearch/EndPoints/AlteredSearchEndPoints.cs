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

        api.MapGet("/personagens/{faction}", async ([FromServices] IApiAlteredService api, string faction) =>
        {
            try
            {
                var _fac = faction;
                var result = await api.ListarTodosOsPersonagens();

                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"Erro: {ex.Message}");
            }
        });

        api.MapGet("/factions", async ([FromServices] IApiAlteredService api) =>
        {
            try
            {
                var result = await api.GetFaction();

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