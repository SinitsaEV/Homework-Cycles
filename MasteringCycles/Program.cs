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
            int firstDivider = 3;
            int secondDivider = 5;

            Random random = new Random();
            int number = random.Next(minValue, maxValue);

            Console.WriteLine($"Ваше случайное число {number}");

            for (int i = 1; i <= number; i++)
            {
                if (i % firstDivider == 0 || i % secondDivider == 0)
                {
                    sum += i;
                }
            }
            
            Console.WriteLine($"Сумма чисел кратных {firstDivider} или {secondDivider} от 0 до {number} равна: {sum}");
        }
    }
}
