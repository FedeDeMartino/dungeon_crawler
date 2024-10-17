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
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/introduction.txt"))
                          .Returns("Welcome to the adventure!");

            var storyManager = new StoryManager(mockFileReader.Object);
            var result = storyManager.LoadIntroduction();

            Assert.Equal("Welcome to the adventure!", result);
        }

        [Fact]
        public void LoadFirstDungeon_ShouldReturnFirstDungeonContent()
        {
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/first_dungeon.txt"))
                          .Returns("You have entered the first dungeon.");

            var storyManager = new StoryManager(mockFileReader.Object);
            var result = storyManager.LoadFirstDungeon();

            Assert.Equal("You have entered the first dungeon.", result);
        }

        [Fact]
        public void LoadFirstDungeonDescription_ShouldReturnFirstDungeonDescriptionContent()
        {
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/first_dungeon_description.txt"))
                          .Returns("The dungeon is dark and full of traps.");

            var storyManager = new StoryManager(mockFileReader.Object);
            var result = storyManager.LoadFirstDungeonDescription();

            Assert.Equal("The dungeon is dark and full of traps.", result);
        }

        [Fact]
        public void LoadSecondDungeon_ShouldReturnSecondDungeonContent()
        {
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/second_dungeon.txt"))
                          .Returns("You enter the second dungeon, where a zombie awaits.");

            var storyManager = new StoryManager(mockFileReader.Object);
            var result = storyManager.LoadSecondDungeon();

            Assert.Equal("You enter the second dungeon, where a zombie awaits.", result);
        }

        [Fact]
        public void LoadSecondDungeonDescription_ShouldReturnSecondDungeonDescriptionContent()
        {
            var mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr => fr.GetFileContent("./txt_files/second_dungeon_description.txt"))
                          .Returns("The air is thick with decay and danger.");

            var storyManager = new StoryManager(mockFileReader.Object);
            var result = storyManager.LoadSecondDungeonDescription();

            Assert.Equal("The air is thick with decay and danger.", result);
        }
    }
}
