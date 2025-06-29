using AlteredSearch.Interface;
using AlteredSearch.Models;
using AlteredSearch.Validator;
using AlteredSearch.Models.Requests;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

            do
            {
                var response = await _apiClient.GetPersonagensAsync(
                    cardTypes: ["CHARACTER"],
                    rarities: ["COMMON"],
                    page: page
                );

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Erro ao buscar página {page}: {response.StatusCode}");

                var content = response.Content;
                if (content == null) break;

                personagens.AddRange(content.HydraMember.Select(c => c.Name));
                total = content.HydraTotalItems;

                page++;

            } while (personagens.Count < total);

            personagens = [.. personagens.Distinct()];

            personagens.Sort();

            return personagens;
        }

        public async Task<List<string>> GetAllUniquesByFactionAndName(GetAllUniquesByFactionAndNameRequest request)
        {

            var result = new List<string>();
            int page = 1, total = int.MaxValue;

            do
            {
                var response = await _apiClient.GetPersonagensAsync(
                    name: request.Name,
                    cardTypes: ["CHARACTER"],
                    rarities: ["UNIQUE"],
                    factions: [request.Faction],
                    page: page
                );

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Erro ao buscar página {page}: {response.StatusCode}");

                var content = response.Content;
                if (content == null) break;

                result.AddRange(content.HydraMember.Select(c => c.Reference));
                total = content.HydraTotalItems;

                page++;

            } while (result.Count < total);

            result = [.. result.Distinct()];

            return result;
        }

        public async Task<List<string>> ListAllCharsByFaction(string faction) => throw new NotImplementedException("rota não implementada");
        
        public async Task<CardSpecification> GetCharacterDetails(string idCharacter)
        {
            var response = await _apiClient.GetCharacterDetail(idCharacter);

            return response.EnsureSuccess();
        }

        public async Task<List<string>> ListAllFactions()
        {
            var response = await _apiClient.GetFactionsAsync();

            var factions = response.EnsureSuccess().HydraMember.GetAllFactions();
            factions.Sort();

            return factions;
        }

        public async Task<string> GetIDUniqueByName(string pName)
        {
            var response = await _apiClient.GetPersonagensAsync(
                cardTypes: ["CHARACTER"],
                rarities: ["UNIQUE"],
                name: pName
            );

            var content = response.EnsureSuccess().Returned("HydraMember");

            var referencia = content.HydraMember.First().Reference;

            return string.Join("_",    referencia
                .Split('_')
                .TakeWhile(part => !int.TryParse(part, out _))) + "_"; ;
        }
    }

    public interface IApiAlteredService
    {
        Task<List<string>> ListAllChars();

        Task<List<string>> ListAllCharsByFaction(string faction);

        Task<List<string>> GetAllUniquesByFactionAndName(GetAllUniquesByFactionAndNameRequest request);

        Task<string> GetIDUniqueByName(string name);

        Task<List<string>> ListAllFactions();

        Task<CardSpecification> GetCharacterDetails(string idCharacter);
    }
}
