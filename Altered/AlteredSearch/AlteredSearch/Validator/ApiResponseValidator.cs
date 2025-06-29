using Refit;
using System.Reflection;
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

    public static T Returned<T>(this T response, string propertyName)
    {
        var property = typeof(T).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);

        if (property == null)
            throw new ArgumentException($"Propriedade '{propertyName}' não encontrada em {typeof(T).Name}.");

        var value = property.GetValue(response);

        if (value == null)
            throw new InvalidOperationException($"A propriedade '{propertyName}' está nula.");

        if (value is IEnumerable<object> collection && !collection.Any())
            throw new InvalidOperationException($"A propriedade '{propertyName}' é uma coleção vazia.");

        return response;
    }
}

