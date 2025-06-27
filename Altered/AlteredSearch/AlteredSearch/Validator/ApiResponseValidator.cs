using Refit;
using System.Runtime.CompilerServices;

namespace AlteredSearch.Validator;

public static class ApiResponseValidator
{
    public static T EnsureSuccess<T>(this ApiResponse<T> response, [CallerMemberName] string caller = "")
    {
        if (!response.IsSuccessStatusCode)
            throw new Exception($"Erro no método '{caller}': {response.StatusCode}");

        return response.Content!;
    }
}

