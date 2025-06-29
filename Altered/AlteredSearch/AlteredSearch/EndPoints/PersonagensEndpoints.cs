using AlteredSearch.Helpers;
using AlteredSearch.Models.Requests;
using AlteredSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlteredSearch.EndPoints;

// EndPoints/PersonagensEndpoints.cs
public static class PersonagensEndpoints
{
    public static IEndpointRouteBuilder MapPersonagensEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/v1/personagens", GetAllCharacter)
            .WithTags("Personagens")
            .WithName("ListarPersonagens");

        routes.MapGet("/api/v1/personagens/{faction}", GetAllCharactersByFaction)
            .WithTags("Personagens")
            .WithName("Lista personagens por facção.");

        routes.MapGet("/api/v1/personagem/{idCharacter}", GetDetailsCharacter)
            .WithTags("Personagens")
            .WithName("Detalhes de um personagem por ID.");


        return routes;
    }

    private static async Task<IResult> GetAllCharacter([FromServices] IApiAlteredService api) =>
        await HandlerEndPoints.HandleRequest(() => api.ListAllChars());

    private static async Task<IResult> GetAllCharactersByFaction([FromServices] IApiAlteredService api, string faction) =>
        await HandlerEndPoints.HandleRequest(() => api.ListAllCharsByFaction(faction));

    private static async Task<IResult> GetDetailsCharacter([FromServices] IApiAlteredService api, string idCharacter) =>
        await HandlerEndPoints.HandleRequest(() => api.GetCharacterDetails(idCharacter));
}
