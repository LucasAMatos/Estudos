using System.Collections.Generic;
using Newtonsoft.Json;

namespace AltSearchForms
{

    public class Card
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        public string Name { get; set; }
        public string Reference { get; set; }
        public string ImagePath { get; set; }
        public string QrUrlDetail { get; set; }
        public bool IsSuspended { get; set; }
        public decimal LowerPrice { get; set; }

        public CardSet CardSet { get; set; }
        public Rarity Rarity { get; set; }
        public CardType CardType { get; set; }
        public List<CardSubType> CardSubTypes { get; set; }
        public List<object> LoreEntries { get; set; }
        public List<object> CardRulings { get; set; }

        public Faction MainFaction { get; set; }

        public Dictionary<string, string> AllImagePath { get; set; }
        public Assets Assets { get; set; }
        public Elements Elements { get; set; }
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

    public class CardSubType
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

    public class Assets
    {
        public List<string> WEB { get; set; }
    }

    public class Elements
    {
        [JsonProperty("MAIN_COST")]
        public string MainCost { get; set; }

        [JsonProperty("RECALL_COST")]
        public string RecallCost { get; set; }

        [JsonProperty("MOUNTAIN_POWER")]
        public string MountainPower { get; set; }

        [JsonProperty("OCEAN_POWER")]
        public string OceanPower { get; set; }

        [JsonProperty("FOREST_POWER")]
        public string ForestPower { get; set; }

        [JsonProperty("MAIN_EFFECT")]
        public string MainEffect { get; set; }

        [JsonProperty("ECHO_EFFECT")]
        public string EchoEffect { get; set; }
    }

}
