using AlteredSearch.Helpers;
using AlteredSearch.Models.Requests;
using AlteredSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlteredSearch.EndPoints;

// EndPoints/PersonagensEndpoints.cs
public static class UnicasEndpoints
{
    public static IEndpointRouteBuilder MapUnicasEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/api/v1/UniqueByFactionAndName", GetAllUniquesByFactionAndName)
            .WithTags("Unicas")
            .WithName("Filtra personagens únicos por facção e nome")
            .Accepts<GetAllUniquesByFactionAndNameRequest>("application/json");

        routes.MapGet("/api/v1/getUniqueReference/", GetIDUnicosByName)
            .WithTags("Unicas")
            .WithName("Retorna referenciade unico pelo nome");
        return routes;
    }

    private static async Task<IResult> GetIDUnicosByName(
        [FromServices] IApiAlteredService api, string name) =>
        await HandlerEndPoints.HandleRequest(() => api.GetIDUniqueByName(name));

    private static async Task<IResult> GetAllUniquesByFactionAndName(
        [FromServices] IApiAlteredService api,
        [FromBody] GetAllUniquesByFactionAndNameRequest request) =>
        await HandlerEndPoints.HandleRequest(() => api.GetAllUniquesByFactionAndName(request));
}
