using Xunit;
using Dungeon.Services;
using System;
using System.IO;

namespace Dungeon.Tests
{
    public class ConsoleWriterTests
    {
        [Fact]
        public void Write_ShouldOutputMessageToConsole()
        {
            var expectedMessage = "Hello, Adventurer!";
            var output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.Write(expectedMessage);

            Assert.Equal(expectedMessage + Environment.NewLine, output.ToString());
        }

        [Fact]
        public void WriteSameLine_ShouldOutputMessageWithoutNewLineToConsole()
        {
            var expectedMessage = "Hello, Adventurer!";
            var output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteSameLine(expectedMessage);

            Assert.Equal(expectedMessage, output.ToString());
        }

        [Fact]
        public void WriteSuccess_ShouldOutputGreenMessageToConsole()
        {
            var expectedMessage = "Success!";
            var output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteSuccess(expectedMessage);

            Assert.Equal(expectedMessage + Environment.NewLine, output.ToString());
        }

        [Fact]
        public void WriteError_ShouldOutputRedMessageToConsole()
        {
            var expectedMessage = "Error!";
            var output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteError(expectedMessage);

            Assert.Equal(expectedMessage + Environment.NewLine, output.ToString());
        }

        [Fact]
        public void WriteSeparator_ShouldOutputSeparatorToConsole()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteSeparator();

            var expectedOutput = Environment.NewLine +
                                 "==================================" + Environment.NewLine +
                                 Environment.NewLine;
            Assert.Equal(expectedOutput, output.ToString());
        }

        [Fact]
        public void AddEmptyLine_ShouldAddOneEmptyLineToConsole()
        {
            var output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.AddEmptyLine();

            Assert.Equal(Environment.NewLine, output.ToString());
        }
    }
}
