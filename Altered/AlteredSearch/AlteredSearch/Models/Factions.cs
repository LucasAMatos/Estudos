namespace AlteredSearch.Models
{
    public class Factions : List<Faction>
    {
        public List<string> GetAllFactions() => this.Select(f => f.Name).ToList() ?? [];
    }
}
