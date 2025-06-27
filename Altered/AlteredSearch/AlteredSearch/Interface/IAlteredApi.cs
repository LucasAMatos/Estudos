using AlteredSearch.Models;
using Refit;

public interface IAlteredApi
{
    [Get("/cards")]
    Task<ApiResponse<RootResponse<Cards>>> GetPersonagensAsync(
    [AliasAs("altArt")] bool? altArt = null,
    [AliasAs("foiled")] bool? foiled = null,
    [AliasAs("isExclusive")] bool? isExclusive = null,
    [AliasAs("isSuspended")] bool? isSuspended = null,
    [AliasAs("translations.name")] string? name = null,
    [AliasAs("artist[]")] IEnumerable<string>? artists = null,
    [AliasAs("cardSet[]")] IEnumerable<string>? cardSets = null,
    [AliasAs("cardSubTypes[]")] IEnumerable<string>? cardSubTypes = null,
    [AliasAs("cardType[]")] IEnumerable<string>? cardTypes = null,
    [AliasAs("factions[]")] IEnumerable<string>? factions = null,
    [AliasAs("keyword[]")] IEnumerable<string>? keywords = null,

    [AliasAs("forestPower[]")] IEnumerable<int>? forestPower = null,
    [AliasAs("mountainPower[]")] IEnumerable<int>? mountainPower = null,
    [AliasAs("oceanPower[]")] IEnumerable<int>? oceanPower = null,
    [AliasAs("recallCost[]")] IEnumerable<int>? recallCost = null,
    [AliasAs("mainCost[]")] IEnumerable<int>? mainCost = null,

    [AliasAs("rarity[]")] IEnumerable<string>? rarities = null,
    [AliasAs("priceMax")] decimal? priceMax = null,

    [AliasAs("page")] int page = 1,
    [AliasAs("itemsPerPage")] int itemsPerPage = 36,
    [AliasAs("locale")] string locale = "en-us"
    );


    [Get("/cards/{id}")]
    Task<ApiResponse<CardSpecification>> GetCharacterDetail(
        [AliasAs("id")] string idCard
    );

    [Get("/factions")]
    Task<ApiResponse<RootResponse<Factions>>> GetFactionsAsync();
}
