using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задача 1");
            ////Написать метод для решения квадратного уравнения
            //Console.WriteLine("Введите значения a, b, c");
            //Console.Write("a = ");
            // double a = double.Parse(Console.ReadLine());
            // Console.Write("b = ");
            // double b = double.Parse(Console.ReadLine());
            // Console.Write("c = ");
            // double c = double.Parse(Console.ReadLine());
            // double x1, x2;
            // var discriminant = Math.Pow(b, 2) - 4 * a * c;
            // if (discriminant < 0)
            // {
            //     Console.WriteLine("Уравнение не имеет корней");
            // }
            // else if (discriminant == 0) 
            // {
            //     x1 = -b / (2 * a);
            //     x2 = x1;
            // }
            // else 
            // {
            //     x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            //     x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            // }
            // Console.WriteLine($"x1 = {(-b + Math.Sqrt(discriminant)) / (2 * a)}; x2 = {(-b - Math.Sqrt(discriminant)) / (2 * a)}");
            //Console.ReadKey();

            //Console.WriteLine("Задача 2");
            ////Вывести на экран массив из 20 случайных чисел.
            ////Ввести два числа из этого массива, которые нужно поменять местами.
            ////Вывести на экран получившийся массив.
            //Random random = new Random();
            //int x = 20;
            //int[] nums = new int[x];
            //for (int i = 0; i < x; i++)
            //{
            //    nums[i] = random.Next(0,100);
            //    Console.WriteLine(nums[i] + " ");
            //}
            //const int i1 = 1;
            //const int i2 = 8;
            //int n = nums[i1];
            //nums[i1] = nums[i2];
            //nums[i2] = n;
            //Console.WriteLine(" ");
            //Console.WriteLine($"Поменяем второе и девятое числа");
            //Console.WriteLine(" ");
            //for (int i = 0; i < nums.Length; i += 1)
            //{
            //    Console.WriteLine($" {nums[i]}");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 3");
            ////Написать метод для сортировки одномерного массива пузырьком.(в отдельной папке)

            Console.WriteLine("Задача 4");
            //Написать метод, где в качества аргумента будет передан массив (ключевое слово params).
            //Вывести сумму элементов массива(вернуть). Вывести(ref) произведение массива.
            //Вывести(out) среднее арифметическое в массиве.

            //Console.ReadKey();

            //Console.WriteLine("Задача 5");
            ////Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли
            ////нарисовать изображение цифры в виде символа #.Если число больше 9 или меньше 0,
            ////то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.
            ////Если пользователь ввёл не цифру, то программа должна выпасть в исключение.
            ////Программа завершает работу, если пользователь введёт слово:
            ////exit или закрыть(оба варианта должны сработать) - консоль закроется.
            //Console.Write("Введите число от 0 до 9: ");
            //int a = int.Parse(Console.ReadLine());



            Console.WriteLine("Задача 6");
            //Создать структуру деда. У деда есть имя, уровень ворчливости (перечисление),
            //массив фраз для ворчания(Например:”проститутки!”, “Гады!”), количество синяков от
            //ударов бабки = 0 по умолчанию. Создать 5 дедов.У каждого деда - разное количество фраз для ворчания.
            //Напишить метод, который на вход принимает деда, список матерных слов(params).
            //Если дед содержит в своей лексике матерные слова из списка, то бабка ставит фингал
            //за каждое слово. Вернуть количество фингалов.


            Console.WriteLine("Задача 7");
            //Написать метод Быстрой сортировки массива(Быстрая сортировка - название сортировки)
        }
    }
}
