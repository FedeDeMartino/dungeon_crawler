using Dungeon.Models;
using Dungeon.Exceptions;

namespace Dungeon.Services
{
    public class SecondDungeonCreator
    {
        private readonly Adventurer _player;
        private readonly Monster _zombie;
        private readonly StoryManager _storyManager;

        public SecondDungeonCreator(Adventurer player)
        {
            _player = player;
            _zombie = new Monster("Zombie");
            IFileReader fileReader = new FileReaderWrapper();
            _storyManager = new StoryManager(fileReader);
        }

        public void ExploreDungeon()
        {
            ConsoleWriter.Write(_storyManager.LoadSecondDungeon());
            ConsoleWriter.Write(_storyManager.LoadSecondDungeonDescription());

            string encounterMessage = "Do you want to (A)ttack or (F)lee?";
            string encounterChoice = GetValidUserChoice(encounterMessage, ["A", "F"]);
            HandleEncounter(encounterChoice);

            ConsoleWriter.AddEmptyLine();
            string doorMessage = "Which door do you want to open?\n(S) South\n(E) East";
            string doorChoice = GetValidUserChoice(doorMessage, ["S", "E"]);
            HandleDoorChoice(doorChoice);
        }

        private void HandleEncounter(string userChoice)
        {
            Encounter encounter = new Encounter(_player, _zombie);
            
            if (userChoice == "A")
            {
                encounter.AdventurerAttacks();
            }
            else
            {
                encounter.MonsterAttacks();
            }

            CheckPlayerStatus();
        }

        private void CheckPlayerStatus()
        {
            if (!_player.IsAlive())
            {
                string message = $"The {_zombie.Name} has killed you. Game Over.";
                ConsoleWriter.WriteError(message);
                throw new CharacterDeadException(message);
            }
            else
            {
                ConsoleWriter.WriteSuccess($"You have defeated the {_zombie.Name}!");
            }
        }

        private string GetValidUserChoice(string prompt, string[] validChoices)
        {
            ConsoleWriter.Write(prompt);
            string userChoice = Console.ReadLine()?.ToUpper() ?? string.Empty;

            while (!Array.Exists(validChoices, choice => choice == userChoice))
            {
                ConsoleWriter.Write("Invalid choice. Please try again.");
                userChoice = Console.ReadLine()?.ToUpper() ?? string.Empty;
            }

            return userChoice;
        }

        private void HandleDoorChoice(string doorChoice)
        {
            if (doorChoice == "S")
            {
                ConsoleWriter.Write("You open the South door...");
                for (int i = 6; i > 0; i--)
                {
                    ConsoleWriter.WriteSameLine(".");
                    Thread.Sleep(500);
                }
                string message = FileReader.getFileContent("./txt_files/victory_description.txt");
                ConsoleWriter.AddEmptyLine();
                ConsoleWriter.WriteSuccess(message);
            }
            else if (doorChoice == "E")
            {
                ConsoleWriter.Write("You open the East door...");
                for (int i = 6; i > 0; i--)
                {
                    ConsoleWriter.WriteSameLine(".");
                    Thread.Sleep(500);
                }
                string message = FileReader.getFileContent("./txt_files/loss_description.txt");
                ConsoleWriter.AddEmptyLine();
                ConsoleWriter.WriteError(message);
            }
        }
    }
}
