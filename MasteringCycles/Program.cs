using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string borderSymbol;
            string playerName;
            int borderWidth = 1;
            int borderCount = 2;

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write(" Введите Ваше имя: ");
            playerName = Console.ReadLine();
            Console.Write(" Введите символ: ");
            borderSymbol = Console.ReadLine();

            for (int i = 0; i <= borderCount * borderWidth; i++) 
            {

                for (int j = 0; j < borderCount * borderWidth + playerName.Length; j++)
                {
                    if (i == borderWidth)
                    {
                        if (j >= borderWidth && j < borderWidth + playerName.Length)
                        {
                            Console.Write(playerName[j - borderWidth]);
                            continue;
                        }
                    }

                    Console.Write(borderSymbol);
                }

                Console.WriteLine();
            }
        }
    }
}