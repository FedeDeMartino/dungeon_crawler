using Dungeon.Services;

public class FileReaderWrapper : IFileReader
{
    public string GetFileContent(string filePath)
    {
        return FileReader.getFileContent(filePath);
    }
}
