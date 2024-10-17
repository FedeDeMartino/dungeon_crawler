namespace Dungeon.Models
{
    public class Armor
    {

      private static readonly Dictionary<string, int> ArmorStats = new Dictionary<string, int>()
        {
            { "Rags", 10 },
            { "Leather Armor", 15 },
            { "Breastplate", 200 }
        };
        public string Name { get; }
        public int Protection { get; }

        public Armor(string name)
        {
            Name = name;
            Protection = ArmorStats[name];
        }

        public string DisplayStats()
        {
            return $"Name: {Name}\nProtection: {Protection}";
        }
    }
}
