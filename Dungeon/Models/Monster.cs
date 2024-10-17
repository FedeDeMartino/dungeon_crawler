namespace Dungeon.Models
{
    public class Monster : Character
    {
        public Monster(string name) : base(name, 30)
        {
        }

        public override string DisplayStats()
        {
            return $"Monster Stats:\n{base.DisplayStats()}";
        }
    }
}
