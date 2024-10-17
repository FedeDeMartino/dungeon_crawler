using Xunit;
using Dungeon.Services;
using System.IO;
using System.Reflection;

namespace Dungeon.Tests
{
    public class FileReaderTests
    {
        [Fact]
        public void GetFileContent_ShouldReturnFileContent_WhenFileExists()
        {
            string fileName = "introduction.txt";
            string expectedContent = "Introduction test\n";
            FileReader fileReader = new FileReader();

            string result = fileReader.GetFileContent("../../../txt_files/introduction.txt");
            Assert.Equal(expectedContent, result);
        }

        [Fact]
        public void GetFileContent_ShouldReturnErrorMessage_WhenFileDoesNotExist()
        {
            string fileName = "nonexistent.txt";
            FileReader fileReader = new FileReader();
            string result = fileReader.GetFileContent(fileName);

            Assert.Contains("Could not find file at", result);
        }
    }
}
