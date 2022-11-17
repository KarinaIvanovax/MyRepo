using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    enum BankAcc
    {
        savings,
        current
    }
    enum Songs
    {
        song11,
        song22,
        song33,
        song44,
    }
    internal class Savings
    {
        public int accnumber;
        public double balanceS;
        public BankAcc type;
        public Savings()
        {
            Random random = new Random();
            int a = random.Next(1000, 9999);
            accnumber = a;
            balanceS = 80000;
            type = BankAcc.savings;
        }
        public void PrintSavings()
        {
            Console.WriteLine($"Номер счета: {accnumber}\nБаланс: {balanceS}\nТип счета: {type}");
        }
        public void MoneyTransferS(int amount)
        {
            this.balanceS -= amount;
            Current balanceC += amount;
        }
    }
    internal class Current
    {
        public int accnumber;
        public double balanceC;
        public BankAcc type;
        public Current()
        {
            Random random = new Random();
            int b = random.Next(1000, 9999);
            accnumber = b;
            balanceC = 80000;
            type = BankAcc.current;
        }
        public void PrintCurrent()
        {
            Console.WriteLine($"Номер счета: {accnumber}\nБаланс: {balanceC}\nТип счета: {type}");
        }
        public void MoneyTransferC(int amount)
        {
            this.balanceC -= amount;
            Savings balanceS += amount;
        }

    }


    internal class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Songs prev { get; set; }
        public override string ToString() { return $"Название: {Name}\nАвтор: {Author}\n:{prev}"; }
        public void Title()
        {
            Song song1 = new Song { Name = "1", Author = "11", prev = Songs.song11 };
            Console.WriteLine(song1.ToString());
            Song song2 = new Song { Name = "2", Author = "22", prev = Songs.song22-1};
            Console.WriteLine(song2.ToString());
            Song song3 = new Song { Name = "3", Author = "33", prev = Songs.song33-1};
            Console.WriteLine(song3.ToString());
            Song song4 = new Song { Name = "4", Author = "44", prev = Songs.song44-1};
            Console.WriteLine(song4.ToString());
        }
        public override bool Equals(object d)
        {
            Song song = d as Song;
            if (song != null)
            {
                if (Name == song.Name && Author == song.Author)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override int GetHashCode() => Name.GetHashCode();
    }

}