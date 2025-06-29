using AlteredSearch.Services;
using AlteredSearch.Helpers;
using Microsoft.AspNetCore.Mvc;
using AlteredSearch.Models.Requests;

namespace AlteredSearch.EndPoints;

// EndPoints/FactionsEndpoints.cs
public static class FactionsEndpoints
{
    public static IEndpointRouteBuilder MapFactionsEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/v1/factions", GetAllFactions)
            .WithTags("Facções");

        return routes;
    }

    private static async Task<IResult> GetAllFactions([FromServices] IApiAlteredService api) =>
        await HandlerEndPoints.HandleRequest(() => api.ListAllFactions());
}
