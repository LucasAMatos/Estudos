using AlteredSearch.Models;
using Refit;

public interface IAlteredApi
{
    [Get("/cards")]
    Task<ApiResponse<RootResponse<Cards>>> GetPersonagensAsync(
        [AliasAs("cardType[]")] string cardType,
        [AliasAs("rarity[]")] string rarity,
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
