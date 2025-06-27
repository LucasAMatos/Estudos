namespace AlteredSearch.Helpers;

internal static class HandlerEndPoints
{    
    internal static async Task<IResult> HandleRequest<T>(Func<Task<T>> func)
    {
        try
        {
            var result = await func();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem($"Erro: {ex.Message}");
        }
    }
}
