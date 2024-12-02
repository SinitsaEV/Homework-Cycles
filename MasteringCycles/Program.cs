using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            const string FirstMessage = "1 message";
            const string SecondMessage = "2 message";
            const string RandomNumber = "random";
            const string ClearConsole = "clear";
            const string ExitWord = "exit";

            Random random = new Random();
            string firstMessageText = " Синица ";
            string secondMessageText = " Евгений ";

            string playerInput;

            Console.WriteLine(" Список команд: \n - 1 message\n - 2 message\n - random\n - clear\n - exit");
            Console.WriteLine(" Введите команду ");

            playerInput = Console.ReadLine();

            while (playerInput != ExitWord)
            {
                switch (playerInput)
                {
                    case FirstMessage:
                        Console.WriteLine(firstMessageText);
                        break;
                    case SecondMessage:
                        Console.WriteLine(secondMessageText);
                        break;
                    case ClearConsole:
                        Console.Clear();
                        break;
                    case RandomNumber:
                        Console.WriteLine(random.Next());
                        break;
                    default:
                        Console.WriteLine("Нет такой команды.");
                        break;
                }

                playerInput = Console.ReadLine();
            }

        }
    }
}