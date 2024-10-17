using Dungeon.Exceptions;
using Dungeon.Models;

namespace Dungeon.Services
{
    public class GameManager
    {
        private Adventurer _player;
        private readonly StoryManager _storyManager;

        public GameManager()
        {
            IFileReader fileReader = new FileReader();
            _storyManager = new StoryManager(fileReader);
            _player = new Adventurer("NoOne");
        }

        public void StartGame()
        {
            try
            {
                Console.Clear();
                Introduction();
                ExploreFirstDungeon();
                Console.Clear();
                ExploreSecondDungeon();
            }
            catch (CharacterDeadException ex)
            {
                ConsoleWriter.WriteError(ex.Message);
            }
        }

        private void Introduction()
        {
          ConsoleWriter.WriteSeparator();
          string introContent = _storyManager.LoadIntroduction();
          ConsoleWriter.Write(introContent);

          ConsoleWriter.Write("Enter your name, adventurer:");
          string? userName = Console.ReadLine();
          while (string.IsNullOrEmpty(userName))
          {
              ConsoleWriter.Write("Please enter a valid name:");
              userName = Console.ReadLine();
          }
          _player = new Adventurer(userName);

          ConsoleWriter.WriteSeparator();
          ConsoleWriter.Write($"Hello, {_player.Name}!");
        }

        private void ExploreFirstDungeon()
        {
            FirstDungeonCreator firstDungeonCreator = new FirstDungeonCreator(_player);
            firstDungeonCreator.ExploreDungeon();
        }

        private void ExploreSecondDungeon()
        {
            SecondDungeonCreator secondDungeonCreator = new SecondDungeonCreator(_player);
            secondDungeonCreator.ExploreDungeon();
        }
    }
}
