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
            string expectedMessage = "Hello, Adventurer!";
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.Write(expectedMessage);

            Assert.Equal(expectedMessage + Environment.NewLine, output.ToString());
        }

        [Fact]
        public void WriteSameLine_ShouldOutputMessageWithoutNewLineToConsole()
        {
            string expectedMessage = "Hello, Adventurer!";
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteSameLine(expectedMessage);

            Assert.Equal(expectedMessage, output.ToString());
        }

        [Fact]
        public void WriteSuccess_ShouldOutputGreenMessageToConsole()
        {
            string expectedMessage = "Success!";
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteSuccess(expectedMessage);

            Assert.Equal(expectedMessage + Environment.NewLine, output.ToString());
        }

        [Fact]
        public void WriteError_ShouldOutputRedMessageToConsole()
        {
            string expectedMessage = "Error!";
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteError(expectedMessage);

            Assert.Equal(expectedMessage + Environment.NewLine, output.ToString());
        }

        [Fact]
        public void WriteSeparator_ShouldOutputSeparatorToConsole()
        {
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.WriteSeparator();

            string expectedOutput = Environment.NewLine +
                                 "==================================" + Environment.NewLine +
                                 Environment.NewLine;
            Assert.Equal(expectedOutput, output.ToString());
        }

        [Fact]
        public void AddEmptyLine_ShouldAddOneEmptyLineToConsole()
        {
            StringWriter output = new StringWriter();
            Console.SetOut(output);
            ConsoleWriter.AddEmptyLine();

            Assert.Equal(Environment.NewLine, output.ToString());
        }
    }
}
