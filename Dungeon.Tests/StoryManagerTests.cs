using Xunit;
using Moq;
using Dungeon.Services;

namespace Dungeon.Tests
{
    public class StoryManagerTests
    {
        [Fact]
        public void LoadIntroduction_ShouldReturnIntroductionContent()
        {
            Mock<IFileReader> mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/introduction.txt"))
                          .Returns("Welcome to the adventure!");

            StoryManager storyManager = new StoryManager(mockFileReader.Object);
            string result = storyManager.LoadIntroduction();

            Assert.Equal("Welcome to the adventure!", result);
        }

        [Fact]
        public void LoadFirstDungeon_ShouldReturnFirstDungeonContent()
        {
            Mock<IFileReader> mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/first_dungeon.txt"))
                          .Returns("You have entered the first dungeon.");

            StoryManager storyManager = new StoryManager(mockFileReader.Object);
            string result = storyManager.LoadFirstDungeon();

            Assert.Equal("You have entered the first dungeon.", result);
        }

        [Fact]
        public void LoadFirstDungeonDescription_ShouldReturnFirstDungeonDescriptionContent()
        {
            Mock<IFileReader> mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/first_dungeon_description.txt"))
                          .Returns("The dungeon is dark and full of traps.");

            StoryManager storyManager = new StoryManager(mockFileReader.Object);
            string result = storyManager.LoadFirstDungeonDescription();

            Assert.Equal("The dungeon is dark and full of traps.", result);
        }

        [Fact]
        public void LoadSecondDungeon_ShouldReturnSecondDungeonContent()
        {
            Mock<IFileReader> mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/second_dungeon.txt"))
                          .Returns("You enter the second dungeon, where a zombie awaits.");

            StoryManager storyManager = new StoryManager(mockFileReader.Object);
            string result = storyManager.LoadSecondDungeon();

            Assert.Equal("You enter the second dungeon, where a zombie awaits.", result);
        }

        [Fact]
        public void LoadSecondDungeonDescription_ShouldReturnSecondDungeonDescriptionContent()
        {
            Mock<IFileReader> mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/second_dungeon_description.txt"))
                          .Returns("The air is thick with decay and danger.");

            StoryManager storyManager = new StoryManager(mockFileReader.Object);
            string result = storyManager.LoadSecondDungeonDescription();

            Assert.Equal("The air is thick with decay and danger.", result);
        }
    }
}
