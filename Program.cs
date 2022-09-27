using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задача 1");
            ////Вася пытается высунуть голову в форточку размерами a и b см.
            ////Приняв условно, что его голова — круглая диаметром d см, определить, сможет ли Вася сделать это.
            ////Для прохождения головы в форточку необходим зазор в 1 см с каждой стороны.
            //Console.Write("Длина форточки: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Ширина форточки: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Диаметр головы: ");
            //int d = int.Parse(Console.ReadLine());
            //if (a > d && b > d)
            //{
            //    Console.WriteLine("Голова Васи пролезет в форточку");
            //}
            //else
            //{
            //    Console.WriteLine("Голова Васи не пролезет в форточку");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 2");
            ////Напечатать таблицу умножения на число n (значение n вводится с клавиатуры; 1 <= n <= 9).
            //Console.Write("Введите цифру от 1 до 9: ");
            //int n = int.Parse(Console.ReadLine());
            //int n1 = n;
            //int n2 = n * 2;
            //int n3 = n * 3;
            //int n4 = n * 4;
            //int n5 = n * 5;
            //int n6 = n * 6;
            //int n7 = n * 7;
            //int n8 = n * 8;
            //int n9 = n * 9;
            //Console.WriteLine($"{n1} {n2} {n3}\n{n4} {n5} {n6}\n{n7} {n8} {n9}");
            //Console.ReadKey();

            //Console.WriteLine("Задача 3");
            ////Создайте программу, которая принимает на вход число и возвращает:
            ////- “Бэнг” -если число делится на 3
            ////- “Бум” -если число делится на 5
            ////- “БэнгБум” -если число делится и на 3, и на 5
            ////- “Мимо” -в остальных случаях.
            ////Примечание: программа выводит только что-то одно.
            //Console.Write("Введите любое число: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 3 == 0 && a % 15 != 0)
            //{
            //    Console.WriteLine("Бэнг");
            //}
            //else if (a % 5 == 0 && a % 15 != 0)
            //{
            //    Console.WriteLine("Бум");
            //}
            //else if (a % 15 == 0)
            //{
            //    Console.WriteLine("БэнгБум");
            //}
            //else
            //{
            //    Console.WriteLine("Мимо");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 4");
            ////Проверить, введена ли с консоли строка ВСЕМИ ЗАГЛАВНЫМИ БУКВАМИ.
            //Console.Write("Введите слово: ");
            //string message1 = Console.ReadLine();
            //bool message;
            //if (message = message1.All(Char.IsUpper))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 5");
            ////Пользователь вводит в консоль положительное целое число, (например, 3)
            ////вывести строку по шаблону: 1 овца... 2 овца... 3 овца...
            //Console.Write("Введите число: ");
            //int a = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i != a + 1)
            //{
            //    Console.Write(i + " овца... ");
            //    i++;
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 6");
            ////Обязательно использовать try-catch-(finally)
            ////Дана непустая последовательность неотрицательных целых чисел,
            ////оканчивающаяся отрицательным числом. Найти среднее арифметическое всех
            ////чисел последовательности(без учета отрицательного числа).
            //try
            //{
            //    int[] numbers = { 9, 7, 5, 3, 1, -1 };
            //    int count = numbers.Count( i => i > 0);
            //    int sum = numbers.Sum();
            //    double x = sum / count;
            //    Console.WriteLine($"Среднее арифметическое: {x}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Нельзя делить на ноль");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 7");
            ////Обязательно использовать try-catch-(finally)
            ////Игральным картам условно присвоены следующие порядковые номера
            ////в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13,
            ////«тузу» — 14.Порядковые номера остальных карт соответствуют их названиям
            ////(«шестерка», «девятка» и т. п.). По заданному номеру карты k(6 <= k <= 14)
            ////определить достоинство соответствующей карты.
            //try
            //{
            //    Console.Write("Введите значение карты: ");
            //    int k = int.Parse(Console.ReadLine());
            //    if (k == 6)
            //    {
            //        Console.WriteLine("Шестерка");
            //    }
            //    else if (k == 7)
            //    {
            //        Console.WriteLine("Семерка");
            //    }
            //    else if (k == 8)
            //    {
            //        Console.WriteLine("Восьмерка");
            //    }
            //    else if (k == 9)
            //    {
            //        Console.WriteLine("Девятка");
            //    }
            //    else if (k == 10)
            //    {
            //        Console.WriteLine("Десятка");
            //    }
            //    else if (k == 11)
            //    {
            //        Console.WriteLine("Валет");
            //    }
            //    else if (k == 12)
            //    {
            //        Console.WriteLine("Дама");
            //    }
            //    else if (k == 13)
            //    {
            //        Console.WriteLine("Король");
            //    }
            //    else if (k == 14)
            //    {
            //        Console.WriteLine("Туз");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Введите число");
            //}
            //finally
            //{
            //    Console.WriteLine("\nКонец ");
            //}
            //Console.ReadKey();

            Console.WriteLine("Задача 8");
            //Создать массив строк. При помощи foreach обойти весь массив.
            //При встрече элемента "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”,
            //т.е. прибавить к результату.Вывести на экран сколько кукол в “сумке”.
            string[] bag = { "Hello Kitty", "Barbie doll", "toys", "Hello Kitty", "something", "Barbie doll", "cars", "Hello Kitty" };
            foreach (string n in bag)
            {
                if (n == "Hello Kitty" && n == "Barbie doll")
                {
                    int count = n.Count();
                    Console.WriteLine($"{n} - столько кукол Barbie и Hello Kitty в сумке");
                }
            }
            Console.ReadKey();


        }
    }
}
