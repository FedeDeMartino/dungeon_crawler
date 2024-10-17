using Dungeon.Services;

namespace Dungeon.Models
{
    public class Encounter
    {
        public Adventurer Adventurer { get; }
        public Monster Monster { get; }

        public Encounter(Adventurer adventurer, Monster monster)
        {
            Adventurer = adventurer;
            Monster = monster;
        }

        public void AdventurerAttacks()
        {
            ExecuteCombat(Adventurer, Monster, "You dealt", "The {0} dealt");
        }

        public void MonsterAttacks()
        {
            ConsoleWriter.Write("You tried to flee but in vain! The monster attacks!");
            ExecuteCombat(Monster, Adventurer, "The {0} dealt", "You dealt");
        }

        private void ExecuteCombat(Character attacker, Character defender, string attackerMessage, string defenderMessage)
        {
            while (defender.IsAlive() && attacker.IsAlive())
            {
                int damage = attacker.TotalDamage(defender.Armor.Protection);
                defender.Health -= damage;
                ConsoleWriter.Write(string.Format(attackerMessage, attacker.Name) + $" {damage} damage!");

                if (defender.IsAlive())
                {
                    int counterDamage = defender.TotalDamage(attacker.Armor.Protection);
                    attacker.Health -= counterDamage;
                    ConsoleWriter.Write(string.Format(defenderMessage, defender.Name) + $" {counterDamage} damage!");
                }
                ConsoleWriter.AddEmptyLine();
                Thread.Sleep(1000);
            }
        }
    }
}
