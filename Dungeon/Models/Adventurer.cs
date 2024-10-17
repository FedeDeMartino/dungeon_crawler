namespace Dungeon.Models
{
    public class Adventurer : Character
    {
        public Adventurer(string name) : base(name, 100)
        {
        }

        public override string DisplayStats()
        {
            return $"Adventurer Stats:\n{base.DisplayStats()}";
        }
    }
}
