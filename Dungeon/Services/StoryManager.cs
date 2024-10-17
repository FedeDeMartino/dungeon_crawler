using Dungeon.Services;

namespace Dungeon.Services
{
    public class StoryManager
    {
        private readonly IFileReader _fileReader;

        public StoryManager(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public string LoadIntroduction()
        {
            return _fileReader.GetFileContent("./txt_files/introduction.txt");
        }

        public string LoadFirstDungeon()
        {
            return _fileReader.GetFileContent("./txt_files/first_dungeon.txt");
        }

        public string LoadFirstDungeonDescription()
        {
            return _fileReader.GetFileContent("./txt_files/first_dungeon_description.txt");
        }

        public string LoadSecondDungeon()
        {
            return _fileReader.GetFileContent("./txt_files/second_dungeon.txt");
        }

        public string LoadSecondDungeonDescription()
        {
            return _fileReader.GetFileContent("./txt_files/second_dungeon_description.txt");
        }
    }
}
