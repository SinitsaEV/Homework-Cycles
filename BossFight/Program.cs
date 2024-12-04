using System;
using System.Text;

namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string baseAttackCommand = "1";
            const string fireballAttackCommand = "2";
            const string explosionAttackCommand = "3";
            const string treatmentCommand = "4";

            Random random = new Random();

            int bossHealth = 100;
            int currentBossDamage;
            int minBossDamage = 10;
            int maxBossDamage = 25;

            int playerDamage = 10;
            int playerHealthMax = 100;
            int playerManaMax = 100;
            int currentPlayerHealth = playerHealthMax;
            int currentPlayerMana = playerManaMax;

            int fireballManaCost = 25;
            int fireballDamage = 25;

            int explosionDamage = 40;
            bool canExplosion = false;

            int treatmentManaRestoration = 10;
            int treatmentHealthRestoration = 15;
            int treatmentCount = 3;

            string playerInput;

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(" Вы попали в комнату босса! ");
            Console.Write($" Команды игрока: \n" +
                $" {baseAttackCommand} - обычная атака\n" +
                $" {fireballAttackCommand} - огненный шар\n" +
                $" {explosionAttackCommand} - взрыв\n" +
                $" {treatmentCommand} - восстановление\n");

            while (bossHealth > 0 && currentPlayerHealth > 0)
            {
                Console.Write(" Введите команду. ");
                playerInput = Console.ReadLine();
                currentBossDamage = random.Next(minBossDamage,maxBossDamage);

                switch (playerInput)
                {
                    case baseAttackCommand:
                        bossHealth -= playerDamage;
                        Console.WriteLine($" Вы нанесли {playerDamage} урона. ");
                        break;

                    case fireballAttackCommand:
                        if(fireballManaCost <= currentPlayerMana)
                        {
                            canExplosion = true;
                            bossHealth -= fireballDamage;
                            currentPlayerMana -= fireballManaCost;
                            Console.WriteLine($" Вы нанесли {fireballDamage} урона. ");
                        }
                        break;

                    case explosionAttackCommand:
                        if (canExplosion)
                        {
                            bossHealth -= explosionDamage;
                            canExplosion = false;
                            Console.WriteLine($" Вы нанесли {explosionDamage} урона. ");
                        }
                        else
                        {
                            Console.WriteLine(" Вы не можете использовать взрыв, до огненного шара. ");
                        }
                        break;

                    case treatmentCommand:
                        if(treatmentCount > 0)
                        {
                            currentPlayerHealth += treatmentHealthRestoration;
                            currentPlayerMana += treatmentManaRestoration;
                            treatmentCount--;
                            Console.WriteLine($" Вы восстановили {treatmentHealthRestoration} здоровья и {treatmentManaRestoration} маны");

                            if(currentPlayerHealth > playerHealthMax)
                            {
                                currentPlayerHealth = playerHealthMax;
                            }

                            if(currentPlayerMana > playerManaMax)
                            {
                                currentPlayerMana = playerManaMax;
                            }
                        }
                        else
                        {
                            Console.WriteLine(" Вы больше не можете использовать восстановление. ");
                        }
                        break;

                    default:
                        Console.WriteLine($" Команды {playerInput} не существует. Вы пропустили ход. ");
                        break;
                }

                currentPlayerHealth -= currentBossDamage;
                Console.WriteLine($" Вам нанесли {currentBossDamage} урона. ");
                Console.WriteLine($" Ваше здоровье: {currentPlayerHealth}. Ваша мана: {currentPlayerMana}." +
                    $"\n Здоровье босса: {bossHealth}.");
            }

            if (currentPlayerHealth <= 0 && bossHealth > 0)
            {
                Console.WriteLine(" Вы проиграли. ");
            }
            else if (bossHealth <= 0 && currentPlayerHealth > 0)
            {
                Console.WriteLine(" Вы победили. ");
            }
            else
            {
                Console.WriteLine(" Ничья. ");
            }
        }
    }
}
