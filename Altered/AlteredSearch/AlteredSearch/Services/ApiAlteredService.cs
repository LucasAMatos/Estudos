using Microsoft.AspNetCore.Mvc.RazorPages;
using AlteredSearch.Models;
using Dynamitey;

namespace AlteredSearch.Services
{
    public class ApiAlteredService : IApiAlteredService
    {
        private readonly IAlteredApi _apiClient;

        public ApiAlteredService(IAlteredApi apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async Task<List<string>> ListAllChars()
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

        public async Task<List<string>> ListAllCharsByFaction(string faction) => throw new NotImplementedException("rota não implementada");
        
        public async Task<CardSpecification> GetCharacterDetails(string idCharacter)
        {
            var response = await _apiClient.GetCharacterDetail(idCharacter);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar personagem {idCharacter}: {response.StatusCode}");

            return response.Content;
        }

        public async Task<List<string>> ListAllFactions()
        {
            var response = await _apiClient.GetFactionsAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro ao buscar facçoes: {response.StatusCode}");

            var faction = response.Content.HydraMember.GetAllFactions();

            faction.Sort();

            return faction;
        }
    }

    public interface IApiAlteredService
    {
        Task<List<string>> ListAllChars();

        Task<List<string>> ListAllCharsByFaction(string faction);

        Task<List<string>> ListAllFactions();

        Task<CardSpecification> GetCharacterDetails(string idCharacter);
    }
}
