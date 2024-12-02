using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            const string Description = "help";
            const string AuthorsLinks = "contacts";
            const string RandomNumber = "random";
            const string ClearConsole = "clear";
            const string ExitWord = "exit";

            Random random = new Random();
            string descriptionText = " Описание Программы ";
            string authorsLinksText = " Ссылки на авторов ";

            string playerInput;

            Console.WriteLine($" Список команд: \n - {Description}\n - {AuthorsLinks}\n - random\n - {ClearConsole}\n - {ExitWord}");
            Console.WriteLine(" Введите команду ");

            playerInput = Console.ReadLine();

            while (playerInput != ExitWord)
            {
                switch (playerInput)
                {
                    case Description:
                        Console.WriteLine(descriptionText);
                        break;
                        
                    case AuthorsLinks:
                        Console.WriteLine(authorsLinksText);
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
