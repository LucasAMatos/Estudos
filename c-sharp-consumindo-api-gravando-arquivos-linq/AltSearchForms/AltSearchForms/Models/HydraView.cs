using Newtonsoft.Json;
using System.Collections.Generic;

public class HydraView
{
    [JsonProperty("@id")]
    public string Id { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("hydra:first")]
    public string First { get; set; }

    [JsonProperty("hydra:last")]
    public string Last { get; set; }

    [JsonProperty("hydra:next")]
    public string Next { get; set; }
}
public class HydraSearch
{
    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("hydra:template")]
    public string Template { get; set; }

    [JsonProperty("hydra:variableRepresentation")]
    public string VariableRepresentation { get; set; }

    [JsonProperty("hydra:mapping")]
    public List<HydraMapping> Mapping { get; set; }
}

public class HydraMapping
{
    [JsonProperty("@type")]
    public string Type { get; set; }

    public string Variable { get; set; }
    public string Property { get; set; }
    public bool Required { get; set; }
}
