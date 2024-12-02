using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string playerInput;
            string exitWord = "exit";

            Console.WriteLine("Введите exit для выхода");

            while ((playerInput = Console.ReadLine()) != exitWord)
            {
                Console.WriteLine("Вы в программе");
            }

            Console.WriteLine("Вы вышли");            
        }
    }
}
