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
            int desiredNumber = 1;
            int desiredDegree = 0;

            Console.OutputEncoding = Encoding.Unicode;

            while (desiredNumber <= randomNumber)
            {
                desiredDegree++;
                desiredNumber *= degreeOfNumber;
            }

            Console.WriteLine($" случайное число: {randomNumber}, минимальная степень {desiredDegree}, число в этой степени {desiredNumber}");
        }
    }
}
