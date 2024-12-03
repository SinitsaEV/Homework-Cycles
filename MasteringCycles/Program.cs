using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "HardPassword";
            int triesCount = 3;
            string playerInput;
            string secretDocuments = " Global secrets ";

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
                        
            for( int i = 1; i <= triesCount; i++ )
            {
                Console.WriteLine(" Введите пароль. ");
                playerInput = Console.ReadLine();

                if (playerInput == password)
                {
                    Console.WriteLine($" Доступ разрешен. \n {secretDocuments} ");
                    break;
                }
                else
                {
                    Console.WriteLine($" Введен не верный пароль, осталось попыток: {triesCount - i}. ");
                }
            }

        }
    }
}
