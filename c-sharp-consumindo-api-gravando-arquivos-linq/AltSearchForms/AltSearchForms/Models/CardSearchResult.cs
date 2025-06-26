using System.Collections.Generic;
using Newtonsoft.Json;

public class CardSearchResult
{
    [JsonProperty("@context")]
    public string Context { get; set; }

    [JsonProperty("@id")]
    public string Id { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("hydra:totalItems")]
    public int TotalItems { get; set; }

    [JsonProperty("hydra:member")]
    public List<CardSummary> Cards { get; set; }

    [JsonProperty("hydra:view")]
    public HydraView View { get; set; }

    [JsonProperty("hydra:search")]
    public HydraSearch Search { get; set; }
}
