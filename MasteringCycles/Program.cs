using System;
using System.Text;

namespace MasteringCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ComandDollarsToRubles = "1";
            const string ComandDollarsToEuros = "2";
            const string ComandEurosToRubles = "3";
            const string ComandEurosToDollars = "4";
            const string ComandRublesToDollars = "5";
            const string ComandRublesToEuros = "6";
            const string ComandExit = "7";

            float dollars;
            float rubles;
            float euros;

            float dollarsToRubles = 107.18f;
            float dollarsToEuros = 0.95007f;
            float eurosToRubles = 112.8f;
            float eurosToDollars = 1.05f;
            float rublesToDollars = 0.00933f;
            float rublesToEuros = 0.008865f;

            int exchangeSum;

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(" Обмен валюты. ");
            
            Console.WriteLine($" Сколько у вас долларов? ");
            dollars = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($" Сколько у вас евро? ");
            euros = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($" Сколько у вас рублей? ");
            rubles = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($" Операции: \n {ComandDollarsToRubles} - Обмен долларов на рубли \n {ComandDollarsToEuros} - Обмен долларов на евро \n {ComandEurosToRubles} - Обмен евро на рубли \n" +
                $" {ComandEurosToDollars} - Обмен евро на доллары \n {ComandRublesToDollars} - Обмен рублей на доллары \n {ComandRublesToEuros} - Обмен рублей на евро \n {ComandExit} - выход ");
            Console.WriteLine(" Выберите операцию. ");
            string playerInputOperation = Console.ReadLine();

            while (playerInputOperation != ComandExit)
            {
                Console.WriteLine(" Какую сумму хотите поменять ? ");
                exchangeSum = Convert.ToInt32(Console.ReadLine());

                switch (playerInputOperation)
                {
                    case ComandDollarsToEuros:
                        if (exchangeSum <= dollars)
                        {
                            dollars -= exchangeSum;
                            euros += exchangeSum * dollarsToEuros;
                        }
                        else
                            Console.WriteLine(" Недостаточно средств. ");
                        break;

                    case ComandDollarsToRubles:
                        if (exchangeSum <= dollars)
                        {
                            dollars -= exchangeSum;
                            rubles += exchangeSum * dollarsToRubles;
                        }
                        else
                            Console.WriteLine(" Недостаточно средств. ");
                        break;

                    case ComandRublesToEuros:
                        if (exchangeSum <= rubles)
                        {
                            rubles -= exchangeSum;
                            euros += exchangeSum * rublesToEuros;
                        }
                        else
                            Console.WriteLine(" Недостаточно средств. ");
                        break;

                    case ComandRublesToDollars:
                        if (exchangeSum <= rubles)
                        {
                            rubles -= exchangeSum;
                            dollars += exchangeSum * rublesToDollars;
                        }
                        else
                            Console.WriteLine(" Недостаточно средств. ");
                        break;

                    case ComandEurosToDollars:
                        if (exchangeSum <= euros)
                        {
                            euros -= exchangeSum;
                            dollars += exchangeSum * eurosToDollars;
                        }
                        else
                            Console.WriteLine(" Недостаточно средств. ");
                        break;

                    case ComandEurosToRubles:
                        if (exchangeSum <= euros)
                        {
                            euros -= exchangeSum;
                            rubles += exchangeSum * eurosToRubles;
                        }
                        else
                            Console.WriteLine(" Недостаточно средств. ");
                        break;

                    default:
                        Console.WriteLine(" Нет такой команды. ");
                        break;
                }

                Console.WriteLine($" У вас {dollars} долларов, {euros} евро, {rubles} рублей ");
                Console.WriteLine(" Выберите операцию. ");
                playerInputOperation = Console.ReadLine();
            }

        }
    }
}