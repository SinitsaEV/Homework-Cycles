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

            string outputNameString = borderSymbol + playerName + borderSymbol;

            for (int i = 0; i <= borderCount * borderWidth; i++) 
            {
                for (int j = 0; j < outputNameString.Length; j++)
                {
                    if (i == borderWidth)
                    {
                        Console.Write(outputNameString);
                        break;
                    }

                    Console.Write(borderSymbol);
                }

                Console.WriteLine();
            }
        }
    }
}