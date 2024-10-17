namespace Dungeon.Services
{
    public class FileReader
    {
        public static string getFileContent(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                return "Could not find file at" + e.Message;
            }
        }
    }
}
