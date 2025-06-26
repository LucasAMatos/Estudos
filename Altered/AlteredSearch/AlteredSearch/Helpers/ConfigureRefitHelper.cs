namespace AlteredSearch.Helpers;
using Refit;

internal static class ConfigureRefitHelper
{
    public static WebApplicationBuilder ConfigureRefit(this WebApplicationBuilder _build)
    {
        _build.Services
         .AddRefitClient<IAlteredApi>()
         .ConfigureHttpClient(c =>
         {
             c.BaseAddress = new Uri("https://api.altered.gg");
         });
        return _build;
    }
}