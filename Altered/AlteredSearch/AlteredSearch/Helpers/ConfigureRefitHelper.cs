namespace AlteredSearch.Helpers;
using Refit;
using System.Net.Http.Headers;

internal static class ConfigureRefitHelper
{
    public static WebApplicationBuilder ConfigureRefit(this WebApplicationBuilder _build)
    {
        _build.Services
         .AddRefitClient<IAlteredApi>()
         .ConfigureHttpClient(c =>
         {
             c.BaseAddress = new Uri("https://api.altered.gg");
             c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/ld+json"));
         });
        return _build;
    }
}