using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    enum BankAcc
    {
        savings,
        current
    }
    internal class BankAccounts
    {
        public int AccNumber { get; set; }
        public decimal Balance { get; set; }
        public BankAcc Type { get; set; }
        public BankAccounts(int accNumber, decimal balance, BankAcc type)
        {
            AccNumber = accNumber;
            Balance = balance;
            Type = type;
        }
        public override string ToString() => $"Номер счета: {AccNumber}\nБаланс: {Balance}\nТип счета: {Type}";
        class CurrentB
        {
 
            public void Current()
            {
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
        class SavingsB
        {
            public void Saving()
            {
                decimal Balance;
                Balance = 0;
                Console.WriteLine("Введите сумму, которую хотите перевести: ");
                decimal sum1 = decimal.Parse(Console.ReadLine());
                if (sum1 > Balance)
                {
                    decimal operation = Balance - sum1;
                    Console.WriteLine($" ");
                }
                //Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 7.2");
            Random random = new Random();
            Console.WriteLine("Текущий счет => нажмите 1\nСберегательный счет => нажмите 2 ");
            int c2 = int.Parse(Console.ReadLine());
            if (c2 == 1)
            {
                int a = random.Next(1000, 9999);
                int cur = int.Parse(Console.ReadLine());
                BankAccounts bank = new BankAccounts(a, cur, BankAcc.savings);
                Console.WriteLine(bank);
                Console.WriteLine("\nХотите перевести деньги с текущего счета на сберегательный?");
                string answer = Console.ReadLine();
                if (answer == "да" || answer == "Да")
                {

                }
                else
                {
                    Console.WriteLine("Завершение программы");
                }
            }
            else if (c2 == 2)
            {
                int b = random.Next(1000, 9999);
                int sav = int.Parse(Console.ReadLine());
                BankAccounts bank = new BankAccounts(b, sav, BankAcc.current);
                Console.WriteLine(bank);
                Console.WriteLine("\nХотите перевести деньги с текущего счета на сберегательный?");
                string answer = Console.ReadLine();
                if (answer == "да" || answer == "Да")
                {

                }
                else
                {
                    Console.WriteLine("Завершение программы");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();
        }
    }
}
