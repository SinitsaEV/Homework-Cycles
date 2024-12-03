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
            int minDegree = 0;

            Console.OutputEncoding = Encoding.Unicode;

            while (desiredNumber <= randomNumber)
            {
                minDegree++;
                desiredNumber *= degreeOfNumber;
            }

            Console.WriteLine($" случайное число: {randomNumber}, минимальная степень {minDegree}, число в этой степени {desiredNumber}");
        }
    }
}using System;
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
            int minDegree = 0;

            Console.OutputEncoding = Encoding.Unicode;

            while (desiredNumber <= randomNumber)
            {
                minDegree++;
                desiredNumber *= degreeOfNumber;
            }

            Console.WriteLine($" случайное число: {randomNumber}, минимальная степень {minDegree}, число в этой степени {desiredNumber}");
        }
    }
}
