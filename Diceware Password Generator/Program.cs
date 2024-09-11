using System.Diagnostics.Tracing;

namespace Diceware_Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordsList wordsList = new WordsList();
            PasswordGenerator passwordGen = new PasswordGenerator();

            Console.WriteLine("Word count: " + wordsList.GetWordsCount());
            Console.WriteLine();
            Console.WriteLine("Press Enter to recieve password.");
            Console.WriteLine();

            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Password: " + passwordGen.GetPassword());
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to recieve password.");
                Console.WriteLine();
            }
        }
    }
}
