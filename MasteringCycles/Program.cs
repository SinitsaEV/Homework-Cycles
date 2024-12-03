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

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write(" Введите Ваше имя: ");
            playerName = Console.ReadLine();
            Console.Write(" Введите символ: ");
            borderSymbol = Console.ReadLine();

            string outputNameString = borderSymbol + playerName + borderSymbol;
            string borderString = "";

            for (int i = 0; i < outputNameString.Length; i++)
            {
                borderString += borderSymbol;
            }

            Console.WriteLine(borderString);
            Console.WriteLine(outputNameString);
            Console.WriteLine(borderString);
        }
    }
}
