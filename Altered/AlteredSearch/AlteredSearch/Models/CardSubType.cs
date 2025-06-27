using Newtonsoft.Json;

public class CardSubType
{
    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("@id")]
    public string IdUrl { get; set; }

    [JsonProperty("reference")]
    public string Reference { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}
