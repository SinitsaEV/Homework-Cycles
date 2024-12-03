using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxValueDivider = 26;
            int minValueDivider = 10;
            int divider = random.Next(minValueDivider, maxValueDivider);

            int maxValueRange = 150;
            int minValueRange = 50;

            int multiples = 0;
            int currentNumber = divider;

            Console.OutputEncoding = Encoding.Unicode;

            for (int i = divider; i <= maxValueRange; i += divider)
            {
                multiples++;
            }

            Console.WriteLine($"В диапозоне от {minValueRange} до {maxValueRange}, {multiples} чисел кратных {divider}.");
        }
    }
}
