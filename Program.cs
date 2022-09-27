using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваша дата рождения: ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            if (today.Month >= birthday.Month && today.Day >= birthday.Day)
            {
                int age = today.Year - birthday.Year;
                Console.WriteLine("Ваш возраст: " + age);
            }
            else
            {
                int age = today.Year - birthday.Year - 1;
                Console.WriteLine("Ваш возраст: " + age);
            }
            Console.ReadKey();
        }
    }
}
