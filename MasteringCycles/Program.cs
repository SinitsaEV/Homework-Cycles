using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 103;
            int step = 7;
            int currentValue = 5;

            while(currentValue <= maxValue)
            {
                Console.WriteLine(currentValue);
                currentValue += step;
            }

            for (currentValue = 5; currentValue <= maxValue; currentValue += step)
            {
                Console.WriteLine(currentValue);
            }
        }
    }
}