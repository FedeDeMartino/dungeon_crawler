namespace Dungeon.Services
{
    public class ConsoleWriter
    {
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }

        public static void WriteSameLine(string message)
        {
            Console.Write(message);
        }

        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteSeparator()
        {
            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("");
        }

        public static void AddEmptyLine()
        {
            Console.WriteLine("");
        }
    }
}
