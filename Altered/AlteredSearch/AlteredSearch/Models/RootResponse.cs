using System.Text.Json.Serialization;

namespace AlteredSearch.Models
{
    public class RootResponse
    {
        [JsonPropertyName("@context")]
        public string Context { get; set; }

        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("hydra:totalItems")]
        public int HydraTotalItems { get; set; }

        [JsonPropertyName("hydra:member")]
        public List<Card> HydraMember { get; set; }
    }
}