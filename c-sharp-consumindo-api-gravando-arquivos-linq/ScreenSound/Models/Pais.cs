using System.Text.Json.Serialization;

namespace ScreenSound.Models
{
    public class Pais
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("populacao")]
        public int Populacao { get; set; }

        [JsonPropertyName("continente")]
        public string Continente { get; set; }

        [JsonPropertyName("idioma")]
        public string Idioma { get; set; }
    }
}
