namespace Dungeon.Services
{
    public class FileReader : IFileReader
    {
        public string GetFileContent(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception e)
            {
                return "Could not find file at" + e.Message;
            }
        }
    }
}
