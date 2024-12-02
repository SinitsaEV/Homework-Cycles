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

            string message;
            int repeats;

            Console.Write("Введите сообщение: ");
            message = Console.ReadLine();
            Console.Write("Введите количество повторений: ");
            repeats = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeats; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
