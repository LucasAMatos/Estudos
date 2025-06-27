using Newtonsoft.Json;

namespace AlteredSearch.Models;

public class CardSet
{
    [JsonProperty("@id")]
    public string IdUrl { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("reference")]
    public string Reference { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}
