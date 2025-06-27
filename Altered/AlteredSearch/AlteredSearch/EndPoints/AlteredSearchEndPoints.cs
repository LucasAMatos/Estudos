using AlteredSearch.Services;
using AlteredSearch.Helpers;
using Microsoft.AspNetCore.Mvc;

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

        api.MapGet("/factions", GetAllFactions)
        .WithTags("Facções");

        return api;
    }

    #region Calls

    private static async Task<IResult> GetAllCharacter([FromServices] IApiAlteredService api)
        => await HandlerEndPoints.HandleRequest(() => api.ListAllChars());

    private static async Task<IResult> GetAllCharactersByFaction([FromServices] IApiAlteredService api, string faction)
        => await HandlerEndPoints.HandleRequest(() => api.ListAllCharsByFaction(faction));

    private static async Task<IResult> GetAllFactions([FromServices] IApiAlteredService api)
        => await HandlerEndPoints.HandleRequest(() => api.ListAllFactions());

    private static async Task<IResult> GetDetailsCharacter([FromServices] IApiAlteredService api, string idCharacter)
        => await HandlerEndPoints.HandleRequest(() => api.GetCharacterDetails(idCharacter));

    #endregion
}