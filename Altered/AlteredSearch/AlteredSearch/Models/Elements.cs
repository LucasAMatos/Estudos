using System.Text.Json.Serialization;

namespace AlteredSearch.Models
{
    public class Elements
    {
        [JsonPropertyName("MAIN_COST")]
        public string MainCost { get; set; }

        [JsonPropertyName("RECALL_COST")]
        public string RecallCost { get; set; }

        [JsonPropertyName("MOUNTAIN_POWER")]
        public string MountainPower { get; set; }

        [JsonPropertyName("OCEAN_POWER")]
        public string OceanPower { get; set; }

        [JsonPropertyName("FOREST_POWER")]
        public string ForestPower { get; set; }

        [JsonPropertyName("MAIN_EFFECT")]
        public string MainEffect { get; set; }

        [JsonPropertyName("ECHO_EFFECT")]
        public string EchoEffect { get; set; }
    }
}
