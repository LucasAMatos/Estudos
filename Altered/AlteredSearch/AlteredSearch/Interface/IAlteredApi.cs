using AlteredSearch.Models;
using Refit;

public interface IAlteredApi
{
    [Get("/cards")]
    Task<ApiResponse<RootResponse>> GetPersonagensAsync(
        [AliasAs("cardType[]")] string cardType,
        [AliasAs("rarity[]")] string rarity,
        [AliasAs("page")] int page = 1,
        [AliasAs("itemsPerPage")] int itemsPerPage = 36,
        [AliasAs("locale")] string locale = "en-us"
    );
}
