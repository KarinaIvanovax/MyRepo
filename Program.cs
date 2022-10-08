using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__ot_01._10._22_
{
    internal class Program
    {
        //public static int MaxNumber(int a1, int a2)
        //{
        //    return Math.Max(a1, a2);
        //}
        //public static void SwapNumbers(ref int a, ref int b)
        //{
        //    a = a + b;
        //    b = a - b;
        //    a = a - b;
        //}
        //static void CommonDivider(int a, int b)
        //{
        //    while (a != b)
        //    {
        //        if (a > b)
        //        {
        //            a = a - b;
        //        }
        //        else
        //        {
        //            b = b - a;
        //        }
        //    }
        //    Console.WriteLine("НОД: " + a);
        //}
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Упражнение 5.1");
            ////Написать метод, возвращающий наибольшее из двух чисел.
            ////Входные параметры метода – два целых числа.Протестировать метод.
            //Console.Write("Введите первое число: ");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.Write($"Введите второе число : ");
            //int a2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Большее число: {MaxNumber(a1, a2)}");
            //Console.ReadKey();

            //Console.WriteLine("Упражнение 5.2");
            ////Написать метод, который меняет местами значения двух передаваемых параметров.
            ////Параметры передавать по ссылке. Протестировать метод.
            //Console.Write("Введите первое число: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число : ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("a = {0}; b = {1}", a, b);
            //SwapNumbers(ref a, ref b);
            //Console.WriteLine("a = {0}; b = {1}", a, b);
            //Console.ReadKey();

            //Console.WriteLine("Упражнение 5.3");
            ////Написать метод вычисления факториала числа,
            ////результат вычислений передавать в выходном параметре. Если метод отработал успешно,
            ////то вернуть значение true; если в процессе вычисления возникло переполнение,
            ////то вернуть значение false.Для отслеживания переполнения значения использовать блок checked.
            //Console.Write("Введите число: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a > 0)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;

            //    return n * Factorial(n - 1);
            //}
            //int factorial = Factorial(a);
            //Console.Write($"Факториал : {factorial} ");
            //Console.ReadKey();

            //Console.WriteLine("Упражнение 5.4");
            ////Написать рекурсивный метод вычисления факториала числа.


            //Console.WriteLine("Домашнее задание 5.1");
            ////Написать метод, который вычисляет НОД двух натуральных чисел(алгоритм Евклида).
            ////Написать метод с тем же именем, который вычисляет НОД трех натуральных чисел.
            //Console.Write("Введите первое число: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число : ");
            //int b = int.Parse(Console.ReadLine());
            //CommonDivider(a, b);
            //Console.ReadKey();

            Console.WriteLine("Домашнее задание 5.2");
            //Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи.
            //Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8, 13...
            //Для таких чисел верно соотношение Fk = F{k - 1} + F{k - 2}.
            Console.WriteLine("Введите значение n-го числа ряда Фибоначчи: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Значение: {Fibonacci(n)}");
            Console.ReadKey();
        }
    }
}
