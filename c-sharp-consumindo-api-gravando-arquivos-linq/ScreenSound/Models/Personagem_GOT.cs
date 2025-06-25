using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    using System.Text.Json.Serialization;
    using System.Collections.Generic;
    using System.Text.Json;

    public class Personagem_GOT
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("gender")]
        public string Genero { get; set; }

        [JsonPropertyName("culture")]
        public string Cultura { get; set; }

        [JsonPropertyName("born")]
        public string Nascimento { get; set; }

        [JsonPropertyName("died")]
        public string Falecimento { get; set; }

        [JsonPropertyName("titles")]
        public List<string> Titulos { get; set; }

        [JsonPropertyName("aliases")]
        public List<string> Apelidos { get; set; }

        [JsonPropertyName("father")]
        public string Pai { get; set; }

        [JsonPropertyName("mother")]
        public string Mae { get; set; }

        [JsonPropertyName("spouse")]
        public string Conjuge { get; set; }

        [JsonPropertyName("allegiances")]
        public List<string> Aliancas { get; set; }

        [JsonPropertyName("books")]
        public List<string> Livros { get; set; }

        [JsonPropertyName("povBooks")]
        public List<string> PovLivros { get; set; }

        [JsonPropertyName("tvSeries")]
        public List<string> SeriesTV { get; set; }

        [JsonPropertyName("playedBy")]
        public List<string> InterpretadoPor { get; set; }


        public static async Task<Personagem_GOT> CarregarPersonagemPorID(int IdPersonagem)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string resposta = await client.GetStringAsync($"https://www.anapioficeandfire.com/api/characters/{IdPersonagem}");
                    return JsonSerializer.Deserialize<Personagem_GOT>(resposta);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Temos um problema: {ex.Message}");
                    return null;
                }
            }
        }
    }

}
