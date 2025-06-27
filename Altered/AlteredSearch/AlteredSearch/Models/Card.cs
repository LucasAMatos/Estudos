using Newtonsoft.Json;

namespace AlteredSearch.Models;

public class Card
{
    [JsonProperty("@context")]
    public string Context { get; set; }

    [JsonProperty("@id")]
    public string IdUrl { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("loreEntries")]
    public List<object> LoreEntries { get; set; }

    [JsonProperty("cardType")]
    public CardType CardType { get; set; }

    [JsonProperty("cardSubTypes")]
    public List<CardSubType> CardSubTypes { get; set; }

    [JsonProperty("cardSet")]
    public CardSet CardSet { get; set; }

    [JsonProperty("rarity")]
    public Rarity Rarity { get; set; }

    [JsonProperty("cardRulings")]
    public List<object> CardRulings { get; set; }

    [JsonProperty("imagePath")]
    public string ImagePath { get; set; }

    [JsonProperty("assets")]
    public Assets Assets { get; set; }

    [JsonProperty("lowerPrice")]
    public int LowerPrice { get; set; }

    [JsonProperty("qrUrlDetail")]
    public string QrUrlDetail { get; set; }

    [JsonProperty("isSuspended")]
    public bool IsSuspended { get; set; }

    [JsonProperty("reference")]
    public string Reference { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("mainFaction")]
    public Faction MainFaction { get; set; }

    [JsonProperty("allImagePath")]
    public Dictionary<string, string> AllImagePath { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("elements")]
    public Elements Elements { get; set; }
}

public class Cards :List<Card>
{
    public List<string> GetAllFactions() => this.Select(f => f.Name).ToList() ?? [];
}


