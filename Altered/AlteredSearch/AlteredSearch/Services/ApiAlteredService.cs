using Refit;

namespace AlteredSearch.Services
{
    public class ApiAlteredService : IApiAlteredService
    {
        private readonly IAlteredApi _apiClient;

        public ApiAlteredService(IAlteredApi apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async Task<List<string>> ListarTodosOsPersonagens()
        {
            var personagens = new List<string>();
            int page = 1, total = int.MaxValue;

            while (personagens.Count < total)
            {
                var response = await _apiClient.GetPersonagensAsync("CHARACTER", "COMMON", page);

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Erro ao buscar página {page}: {response.StatusCode}");

                var content = response.Content;
                if (content == null) break;

                personagens.AddRange(content.HydraMember.Select(c => c.Name));
                total = content.HydraTotalItems;
                page++;
            }

            personagens = [.. personagens.Distinct()];

            personagens.Sort();

            return personagens;
        }
    }

    public interface IApiAlteredService
    {
        Task<List<string>> ListarTodosOsPersonagens();
    }
}
