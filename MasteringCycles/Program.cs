using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int maxValue = 101;
            int minValue = 0;
            int sum = 0;

            Random random = new Random();
            int number = random.Next(minValue, maxValue);

            Console.WriteLine($"Ваше случайное число {number}");

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма чисел кратных 3 или 5 от 0 до {number} равна: {sum}");
        }
    }
}