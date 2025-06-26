using Newtonsoft.Json;

public class CardType
{
    [JsonProperty("@id")]
    public string IdRef { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    public string Id { get; set; }
    public string Reference { get; set; }
    public string Name { get; set; }
}

public class Rarity
{
    [JsonProperty("@id")]
    public string IdRef { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    public string Id { get; set; }
    public string Reference { get; set; }
    public string Name { get; set; }
}

public class CardSet
{
    [JsonProperty("@id")]
    public string IdRef { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    public string Id { get; set; }
    public string Reference { get; set; }
    public string Name { get; set; }
}

public class Faction
{
    [JsonProperty("@id")]
    public string IdRef { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    public string Id { get; set; }
    public string Reference { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
}
