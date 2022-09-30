using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ot_24._09._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Упражнение 4.1");
            ////Написать программу, которая читает с экрана число от 1
            ////до 365(номер дня в году), переводит этот число в месяц и день месяца.
            ////Например, число 40 соответствует 9 февраля(високосный год не учитывать).
            //Console.Write("Введите число от 1 до 365: ");
            //int day = int.Parse(Console.ReadLine());
            //if (0 < day && day < 32)
            //{
            //    Console.WriteLine($"{day} января");
            //}
            //else if (day > 31 && day < 60)
            //{
            //    int a = day - 31;
            //    Console.WriteLine($"{a} февраля");
            //}
            //else if (day > 59 && day < 91)
            //{
            //    int b = day - 59;
            //    Console.WriteLine($"{b} марта");
            //}
            //else if (day > 90 && day < 121)
            //{
            //    int c = day - 90;
            //    Console.WriteLine($"{c} апреля");
            //}
            //else if (day > 120 && day < 152)
            //{
            //    int d = day - 120;
            //    Console.WriteLine($"{d} мая");
            //}
            //else if (day > 151 && day < 182)
            //{
            //    int e = day - 151;
            //    Console.WriteLine($"{e} июня");
            //}
            //else if (day > 181 && day < 213)
            //{
            //    int f = day - 181;
            //    Console.WriteLine($"{f} июля");
            //}
            //else if (day > 212 && day < 243)
            //{
            //    int g = day - 212;
            //    Console.WriteLine($"{g} августа");
            //}
            //else if (day > 242 && day < 274)
            //{
            //    int h = day - 242;
            //    Console.WriteLine($"{h} сентября");
            //}
            //else if (day > 273 && day < 304)
            //{
            //    int i = day - 273;
            //    Console.WriteLine($"{i} октября");
            //}
            //else if (day > 303 && day < 335)
            //{
            //    int j = day - 303;
            //    Console.WriteLine($"{j} ноября");
            //}
            //else if (day > 334 && day < 366)
            //{
            //    int k = day - 334;
            //    Console.WriteLine($"{k} декабря");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Упражнение 4.2");
            //Добавить к задаче из предыдущего упражнения
            //проверку числа введенного пользователем. Если число меньше 1 или больше 365,
            //программа должна вырабатывать исключение, и выдавать на экран сообщение.
            //Сразу учла это условие

            //Console.WriteLine("Упражнение 4.1 (дз)");
            ////Изменить программу из упражнений 4.1 и 4.2 так,
            ////чтобы она учитывала год(високосный или нет). Год вводится с экрана. (Год
            ////високосный, если он делится на четыре без остатка, но если он делится на 100
            ////без остатка, это не високосный год.Однако, если он делится без остатка на 400,
            ////это високосный год.)
            //Console.Write("Введите год: ");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    Console.Write("Введите число от 1 до 366: ");
            //    int day = int.Parse(Console.ReadLine());
            //    if (0 < day && day < 32)
            //    {
            //        Console.WriteLine($"{day} января");
            //    }
            //    else if (day > 31 && day < 61)
            //    {
            //        int a = day - 31;
            //        Console.WriteLine($"{a} февраля");
            //    }
            //    else if (day > 60 && day < 92)
            //    {
            //        int b = day - 60;
            //        Console.WriteLine($"{b} марта");
            //    }
            //    else if (day > 91 && day < 122)
            //    {
            //        int c = day - 91;
            //        Console.WriteLine($"{c} апреля");
            //    }
            //    else if (day > 121 && day < 153)
            //    {
            //        int d = day - 121;
            //        Console.WriteLine($"{d} мая");
            //    }
            //    else if (day > 152 && day < 183)
            //    {
            //        int e = day - 152;
            //        Console.WriteLine($"{e} июня");
            //    }
            //    else if (day > 182 && day < 214)
            //    {
            //        int f = day - 182;
            //        Console.WriteLine($"{f} июля");
            //    }
            //    else if (day > 213 && day < 244)
            //    {
            //        int g = day - 213;
            //        Console.WriteLine($"{g} августа");
            //    }
            //    else if (day > 243 && day < 275)
            //    {
            //        int h = day - 242;
            //        Console.WriteLine($"{h} сентября");
            //    }
            //    else if (day > 274 && day < 305)
            //    {
            //        int i = day - 274;
            //        Console.WriteLine($"{i} октября");
            //    }
            //    else if (day > 304 && day < 336)
            //    {
            //        int j = day - 304;
            //        Console.WriteLine($"{j} ноября");
            //    }
            //    else if (day > 335 && day < 367)
            //    {
            //        int k = day - 335;
            //        Console.WriteLine($"{k} декабря");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error");
            //    }
            //    Console.ReadKey();
            //}
            //else 
            //{
            //    Console.Write("Введите число от 1 до 365: ");
            //    int day = int.Parse(Console.ReadLine());
            //    if (0 < day && day < 32)
            //    {
            //        Console.WriteLine($"{day} января");
            //    }
            //    else if (day > 31 && day < 60)
            //    {
            //        int a = day - 31;
            //        Console.WriteLine($"{a} февраля");
            //    }
            //    else if (day > 59 && day < 91)
            //    {
            //        int b = day - 59;
            //        Console.WriteLine($"{b} марта");
            //    }
            //    else if (day > 90 && day < 121)
            //    {
            //        int c = day - 90;
            //        Console.WriteLine($"{c} апреля");
            //    }
            //    else if (day > 120 && day < 152)
            //    {
            //        int d = day - 120;
            //        Console.WriteLine($"{d} мая");
            //    }
            //    else if (day > 151 && day < 182)
            //    {
            //        int e = day - 151;
            //        Console.WriteLine($"{e} июня");
            //    }
            //    else if (day > 181 && day < 213)
            //    {
            //        int f = day - 181;
            //        Console.WriteLine($"{f} июля");
            //    }
            //    else if (day > 212 && day < 243)
            //    {
            //        int g = day - 212;
            //        Console.WriteLine($"{g} августа");
            //    }
            //    else if (day > 242 && day < 274)
            //    {
            //        int h = day - 242;
            //        Console.WriteLine($"{h} сентября");
            //    }
            //    else if (day > 273 && day < 304)
            //    {
            //        int i = day - 273;
            //        Console.WriteLine($"{i} октября");
            //    }
            //    else if (day > 303 && day < 335)
            //    {
            //        int j = day - 303;
            //        Console.WriteLine($"{j} ноября");
            //    }
            //    else if (day > 334 && day < 366)
            //    {
            //        int k = day - 334;
            //        Console.WriteLine($"{k} декабря");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error");
            //    }
            //    Console.ReadKey();
            }
        }
    }
}
