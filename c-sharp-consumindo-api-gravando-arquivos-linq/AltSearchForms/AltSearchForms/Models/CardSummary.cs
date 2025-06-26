using AltSearchForms;
using Newtonsoft.Json;
using System.Collections.Generic;

public class CardSummary
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Reference { get; set; }

    [JsonProperty("@id")]
    public string ApiLink { get; set; }

    public string ImagePath { get; set; }

    public string QrUrlDetail { get; set; }

    public bool IsSuspended { get; set; }

    public CardType CardType { get; set; }

    public Rarity Rarity { get; set; }

    public CardSet CardSet { get; set; }

    public Faction MainFaction { get; set; }

    public Dictionary<string, string> Elements { get; set; }

    public List<object> CardSubTypes { get; set; }

    public List<object> Assets { get; set; }
}
