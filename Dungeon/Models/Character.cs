using Dungeon.Services;

namespace Dungeon.Models
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        protected Character(string name, int health)
        {
            Name = name;
            Health = health;
            Weapon = new Weapon("Fists");
            Armor = new Armor("Rags");
        }

        public void EquipWeapon(string newWeapon)
        {
            Weapon = new Weapon(newWeapon);
        }

        public void EquipArmor(string newArmor)
        {
            Armor = new Armor(newArmor);
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public int TotalDamage(int opponentProtection)
        {
            int d20Roll = new System.Random().Next(1, 21);
            ConsoleWriter.Write($"{Name} rolled a {d20Roll}!");

            if (d20Roll == 1 || d20Roll + Weapon.Damage < opponentProtection)
            {
                ConsoleWriter.WriteError("Miss!");
                return 0;
            }
            else if (d20Roll == 20)
            {
                ConsoleWriter.WriteSuccess("Critical Hit!");
                return Weapon.Damage * 2;
            }

            ConsoleWriter.WriteSuccess("Hit!");
            return Weapon.Damage;
        }

        public virtual string DisplayStats()
        {
            return $"Name: {Name}\nHealth: {Health} HP\nWeapon: {Weapon.Name}\nArmor: {Armor.Name}";
        }
    }
}
