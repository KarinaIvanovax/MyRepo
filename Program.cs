using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 9.1");
            Savings sav = new Savings();
            sav.PrintSavings();
            Current cur = new Current();
            cur.PrintCurrent();
            Console.WriteLine();
            Console.WriteLine("\nХотите перевести деньги из первого банка во второй?");
            string answer1 = Console.ReadLine();
            if (answer1 == "да" || answer1 == "Да")
            {
                Console.WriteLine("С какого счета хотите перевести?");
                string answer2 = Console.ReadLine();
                if (answer2 == "сберегательный")
                {
                    Console.WriteLine("Какую сумму хотите перевести?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    sav.MoneyTransferS(amount);
                }
                else if (answer2 == "текущий")
                {
                    Console.WriteLine("Какую сумму хотите перевести?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    cur.MoneyTransferC(amount);
                }
                else
                {
                    Console.WriteLine("Завершение программы");
                }
            }
            else
            {
                Console.WriteLine("Завершение программы");
            }
            Console.WriteLine();

            Console.WriteLine("Домашнее задание 9.1");
            Song mySong = new Song();
            mySong.Title();
        }
    }
}
