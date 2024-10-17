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
            var fileName = "introduction.txt";
            var expectedContent = "Introduction test\n";

            var result = FileReader.getFileContent("../../../txt_files/introduction.txt");
            Assert.Equal(expectedContent, result);
        }

        [Fact]
        public void GetFileContent_ShouldReturnErrorMessage_WhenFileDoesNotExist()
        {
            var fileName = "nonexistent.txt";
            var result = FileReader.getFileContent(fileName);

            Assert.Contains("Could not find file at", result);
        }
    }
}
