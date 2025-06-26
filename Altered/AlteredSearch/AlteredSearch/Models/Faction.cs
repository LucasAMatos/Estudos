using Newtonsoft.Json;

namespace AlteredSearch.Models
{
    public class Faction
    {
        [JsonProperty("@id")]
        public string AtId { get; set; }

        [JsonProperty("@type")]
        public string AtType { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
