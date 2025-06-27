using AlteredSearch.Services;
using AlteredSearch.Helpers;
using Microsoft.AspNetCore.Mvc;
using AlteredSearch.Models.Requests;

namespace AlteredSearch.EndPoints;

internal static class AlteredSearchEndPoints
{
    internal static WebApplication RegisterEndpoints(this WebApplication api)
    {

        api.MapGet("/", () => Results.Redirect("/swagger"))
        .ExcludeFromDescription();

        api.MapGet("/personagens", GetAllCharacter)
        .WithTags("Personagens");

        api.MapGet("/personagens/{faction}", GetAllCharactersByFaction)
        .WithTags("Personagens");

        api.MapGet("/personagemPorId/{idCharacter}", GetDetailsCharacter)
        .WithTags("Personagens");

        api.MapPost("/Unicos",GetAllUniquesByFactionAndName)
        .WithTags("Personagens");

        api.MapGet("/factions", GetAllFactions)
        .WithTags("Facções");

        return api;
    }

    #region Calls

    private static async Task<IResult> GetAllCharacter([FromServices] IApiAlteredService api)
        => await HandlerEndPoints.HandleRequest(() => api.ListAllChars());

    private static async Task<IResult> GetAllCharactersByFaction([FromServices] IApiAlteredService api, string faction)
        => await HandlerEndPoints.HandleRequest(() => api.ListAllCharsByFaction(faction));

    private static async Task<IResult> GetDetailsCharacter([FromServices] IApiAlteredService api, string idCharacter)
        => await HandlerEndPoints.HandleRequest(() => api.GetCharacterDetails(idCharacter));

    private static async Task<IResult> GetAllUniquesByFactionAndName([FromServices] IApiAlteredService api, [FromBody] GetAllUniquesByFactionAndNameRequest request)
        => await HandlerEndPoints.HandleRequest(() => api.GetAllUniquesByFactionAndName(request));

    private static async Task<IResult> GetAllFactions([FromServices] IApiAlteredService api)
        => await HandlerEndPoints.HandleRequest(() => api.ListAllFactions());


    #endregion
}