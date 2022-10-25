using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7__ot_20._10._22_
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

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 7.1");
            Console.WriteLine("Текущий счет => нажмите 1\nСберегательный счет => нажмите 2 ");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                BankAccounts bank = new BankAccounts(000000, 10000, BankAcc.savings);
                Console.WriteLine(bank);
            }
            else if (c == 2)
            {
                BankAccounts bank = new BankAccounts(00000, 10000, BankAcc.current);
                Console.WriteLine(bank);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            Console.WriteLine("Задача 7.2");
            Random random = new Random();
            Console.WriteLine("Текущий счет => нажмите 1\nСберегательный счет => нажмите 2 ");
            int c2 = int.Parse(Console.ReadLine());
            if (c2 == 1)
            {
                int a = random.Next(1000, 9999);
                BankAccounts bank = new BankAccounts(a, 10000, BankAcc.savings);
                Console.WriteLine(bank);
            }
            else if (c2 == 2)
            {
                int b = random.Next(1000, 9999);
                BankAccounts bank = new BankAccounts(b, 10000, BankAcc.current);
                Console.WriteLine(bank);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();

            Console.WriteLine("Задача 7.3");
            Console.WriteLine("Текущий счет => нажмите 1\nСберегательный счет => нажмите 2 ");
            int c3 = int.Parse(Console.ReadLine());
            if (c3 == 1)
            {
                decimal balance = 99999;
                BankAccounts bank = new BankAccounts(000000, balance, BankAcc.savings);
                Console.WriteLine(bank);
                Console.WriteLine("Хотите снять средства со сберегательного счета?");
                string m = Console.ReadLine();
                if (m == "да" || m == "Да")
                {
                    Console.Write("Введите сумму, которую хотите снять: ");
                    decimal sum = int.Parse(Console.ReadLine());
                    if (sum > balance)
                    {
                        Console.WriteLine("Невозможно провести операцию");
                    }
                    else
                    {
                        decimal newbalance = balance - sum;
                        Console.WriteLine($"Остаток на счете: {newbalance}");
                    }
                }
                else
                {
                    Console.WriteLine("Завершение программы");
                }
            }
            else if (c3 == 2)
            {
                decimal balance = 19839547;
                BankAccounts bank = new BankAccounts(00000,balance, BankAcc.current);
                Console.WriteLine(bank);
                Console.WriteLine("Хотите снять средства с текущего счета?");
                string m = Console.ReadLine();
                if (m == "да" || m == "Да")
                {
                    Console.Write("Введите сумму, которую хотите снять: ");
                    decimal sum = int.Parse(Console.ReadLine());
                    if (sum > balance)
                    {
                        Console.WriteLine("Невозможно провести операцию");
                    }
                    else
                    {
                        decimal newbalance = balance - sum;
                        Console.WriteLine($"Остаток на счете: {newbalance}");
                    }
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
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 7.1");

        }
    }
}
