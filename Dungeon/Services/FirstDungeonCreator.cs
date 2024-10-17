using Dungeon.Models;

namespace Dungeon.Services
{
    public class FirstDungeonCreator
    {
      private readonly Adventurer _player;
      private readonly StoryManager _storyManager;

      public FirstDungeonCreator(Adventurer player)
      {
          _player = player;
          IFileReader fileReader = new FileReader();
          _storyManager = new StoryManager(fileReader);
      }

      public void ExploreDungeon()
      {
          string dungeonStory = _storyManager.LoadFirstDungeon();
          ConsoleWriter.Write(dungeonStory);

          string dungeonDescription = _storyManager.LoadFirstDungeonDescription();
          ConsoleWriter.Write(dungeonDescription);

          HandlePlayerChoice();
      }
        
      private void HandlePlayerChoice()
      {
          string userChoice = Console.ReadLine()?.ToUpper() ?? string.Empty;

          while (userChoice != "T" && userChoice != "D")
          {
              ConsoleWriter.Write("Invalid choice. Please enter T or D.");
              userChoice = Console.ReadLine()?.ToUpper() ?? string.Empty;
          }

          if (userChoice == "T")
          {
              _player.EquipWeapon("Rusty Sword");
              ConsoleWriter.Write("🗡️ You have equipped the Rusty Sword 🗡️. You continue towards the door.");
          } 
          else if (userChoice == "D")
          {
            ConsoleWriter.Write("You decide to ignore the sword and continue towards the door.");
          }
      }
    }
}
