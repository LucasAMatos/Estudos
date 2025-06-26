namespace AlteredSearch.Models
{
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public string ImagePath { get; set; }
        public string QrUrlDetail { get; set; }
        public bool IsSuspended { get; set; }
        public Elements Elements { get; set; }
        public CardType CardType { get; set; }
        public Rarity Rarity { get; set; }
        public CardSet CardSet { get; set; }
        public Faction MainFaction { get; set; }
    }
}
