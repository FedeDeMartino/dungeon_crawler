namespace Dungeon.Models
{
    public class Weapon
    {

      private static readonly Dictionary<string, int> WeaponDamage = new Dictionary<string, int>()
        {
            { "Rusty Sword", 8 },
            { "Iron Sword", 15 },
            { "Staff", 10 },
            { "Axe", 18 },
            { "Fists", 5}
        };
        public string Name { get; }
        public int Damage { get; }

        public Weapon(string name)
        {
            Name = name;
            Damage = WeaponDamage[name];
        }

        public string DisplayStats()
        {
            return $"Name: {Name}\nDamage: {Damage}";
        }
    }
}
