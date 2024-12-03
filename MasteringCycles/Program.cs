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
            int degreeOfNumber = 2;
            int minNumber = 1;
            int minDegree = 0;

            Console.OutputEncoding = Encoding.Unicode;

            while (minNumber < randomNumber )
            {
                minDegree++;
                minNumber *= degreeOfNumber;
            }
            
            Console.WriteLine($" случайное число: {randomNumber}, минимальная степень {minDegree}, число в этой степени {minNumber}");
        }
    }
}
