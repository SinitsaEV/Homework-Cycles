using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next();
            int currentValue = 1;
            int degreeOfNumber = 2;
            int minDegree = 0;

            Console.OutputEncoding = Encoding.Unicode;

            while (currentValue < randomNumber )
            {
                minDegree++;
                currentValue *= degreeOfNumber;
            }
            Console.WriteLine($" случайное число: {randomNumber}, минимальная степень {minDegree}, число в этой степени {currentValue}");
        }
    }
}