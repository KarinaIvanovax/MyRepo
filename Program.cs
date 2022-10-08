using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework5
{
    //struct grandfather
    //{
    //    public int level_of_grunt;
    //    public string name;
    //    public string secondName;
    //    public string category;
    //    public int alcohollevel;
    //}
    internal class Program
    {
        //public static double OperetionsArray(double sum, ref double mult, out double sr_arif, double[] array)
        //{
        //    sum = 0;
        //    mult = 1;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        mult *= array[i];
        //    }
        //    sr_arif = sum / array.Length;
        //    return sum;
        //}

        public static void SpeedSorting(double[] arr, int minIndex, int maxIndex)
        {
            double s = arr[(maxIndex - minIndex) / 2 + minIndex];
            int i = minIndex, j = maxIndex;
            while (i <= j)
            {
                while (arr[i] < s && i <= maxIndex)
                {
                    ++i;
                }
                while (arr[j] > s && j >= minIndex)
                {
                    --j;
                }
                if (i <= j)
                {
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (j > minIndex)
            {
                SpeedSorting(arr, minIndex, j);
            }
            if (i < maxIndex)
            {
                SpeedSorting(arr, i, maxIndex);
            }
        }
        static void Main(string[] args)
        {
            //    Console.WriteLine("Задача 1");
            //    //Написать метод для решения квадратного уравнения
            //    Console.WriteLine("Введите значения a, b, c");
            //    Console.Write("a = ");
            //    double a = double.Parse(Console.ReadLine());
            //    Console.Write("b = ");
            //    double b = double.Parse(Console.ReadLine());
            //    Console.Write("c = ");
            //    double c = double.Parse(Console.ReadLine());
            //    double x1, x2;
            //    var discriminant = Math.Pow(b, 2) - 4 * a * c;
            //    if (discriminant < 0)
            //    {
            //        Console.WriteLine("Уравнение не имеет корней");
            //    }
            //    else if (discriminant == 0)
            //    {
            //        x1 = -b / (2 * a);
            //        x2 = x1;
            //    }
            //    else
            //    {
            //        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            //        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            //    }
            //    Console.WriteLine($"x1 = {(-b + Math.Sqrt(discriminant)) / (2 * a)}; x2 = {(-b - Math.Sqrt(discriminant)) / (2 * a)}");
            //    Console.ReadKey();

            //    Console.WriteLine("Задача 2");
            //    //Вывести на экран массив из 20 случайных чисел.
            //    //Ввести два числа из этого массива, которые нужно поменять местами.
            //    //Вывести на экран получившийся массив.
            //    Random random = new Random();
            //    int x = 20;
            //    int[] nums = new int[x];
            //    for (int i = 0; i < x; i++)
            //    {
            //        nums[i] = random.Next(0, 100);
            //        Console.WriteLine(nums[i] + " ");
            //    }
            //    const int i1 = 1;
            //    const int i2 = 8;
            //    int n = nums[i1];
            //    nums[i1] = nums[i2];
            //    nums[i2] = n;
            //    Console.WriteLine(" ");
            //    Console.WriteLine($"Поменяем второе и девятое числа");
            //    Console.WriteLine(" ");
            //    for (int i = 0; i < nums.Length; i += 1)
            //    {
            //        Console.WriteLine($" {nums[i]}");
            //    }
            //    Console.ReadKey();

            //    Console.WriteLine("Задача 3");
            //    //Написать метод для сортировки одномерного массива пузырьком.(в отдельной папке)


            //Console.WriteLine("Задача 4");
            ////Написать метод, где в качества аргумента будет передан массив(ключевое слово params).
            ////Вывести сумму элементов массива(вернуть). Вывести(ref) произведение массива.
            ////Вывести(out) среднее арифметическое в массиве.
            //Console.WriteLine("Введите 5 чисел:");
            //double sum = 0;
            //double product = 1;
            //double average = 0;
            //double[] nums = new double[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    nums[i] = double.Parse(Console.ReadLine());
            //}
            //OperetionsArray(sum, ref product, out average, nums);
            //Console.WriteLine($"Сумма: {OperetionsArray(sum, ref product, out average, nums)}");
            //Console.WriteLine($"Произведение: {product}");
            //Console.WriteLine($"Среднее арифметическое: {average}");
            //Console.ReadKey();

            //Console.WriteLine("Задача 5");
            ////Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли
            ////нарисовать изображение цифры в виде символа #.Если число больше 9 или меньше 0,
            ////то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.
            ////Если пользователь ввёл не цифру, то программа должна выпасть в исключение.
            ////Программа завершает работу, если пользователь введёт слово:
            ////exit или закрыть(оба варианта должны сработать) - консоль закроется.
            //Console.Write("Введите число от 0 до 9: ");
            //int k = int.Parse(Console.ReadLine());
            //try
            //{
            //    if (k == 0)
            //    {
            //        Console.WriteLine("###\n# #\n# #\n# #\n###");
            //    }
            //    else if (k == 1)
            //    {
            //        Console.WriteLine("##\n #\n #\n #\n###");
            //    }
            //    else if (k == 2)
            //    {
            //        Console.WriteLine("###\n  #\n###\n#\n###");
            //    }
            //    else if (k == 3)
            //    {
            //        Console.WriteLine("###\n  #\n##\n  #\n###");
            //    }
            //    else if (k == 4)
            //    {
            //        Console.WriteLine("# #\n# #\n###\n  #\n  #");
            //    }
            //    else if (k == 5)
            //    {
            //        Console.WriteLine("###\n#\n###\n  #\n###");
            //    }
            //    else if (k == 6)
            //    {
            //        Console.WriteLine("###\n#\n###\n# #\n###");
            //    }
            //    else if (k == 7)
            //    {
            //        Console.WriteLine("###\n  #\n ###\n  #\n  #");
            //    }
            //    else if (k == 8)
            //    {
            //        Console.WriteLine("###\n# #\n###\n# #\n###");
            //    }
            //    else if (k == 9)
            //    {
            //        Console.WriteLine("###\n# #\n###\n  #\n###");
            //    }
            //    else
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.Clear();
            //        Thread.Sleep(3000);
            //        Console.ResetColor();
            //        Console.Clear();
            //        Console.WriteLine("Ошибка!");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Вы ввели не число!");
            //}
            //string message = Console.ReadLine();
            //if (message == "exit" || message == "закрыть")
            //{
            //    Environment.Exit(0);
            //}
            //Console.ReadKey();


            //Console.WriteLine("Задача 6");
            ////Создать структуру деда. У деда есть имя, уровень ворчливости (перечисление),
            ////массив фраз для ворчания(Например:”проститутки!”, “Гады!”), количество синяков от
            ////ударов бабки = 0 по умолчанию. Создать 5 дедов.У каждого деда - разное количество фраз для ворчания.
            ////Напишить метод, который на вход принимает деда, список матерных слов(params).
            ////Если дед содержит в своей лексике матерные слова из списка, то бабка ставит фингал
            ////за каждое слово. Вернуть количество фингалов.

            //var person1 = new grandfather();
            //person1.name = "Василий";
            //person1.level_of_grunt = 1;
            //string[] a = { "Гады!", "Проститутки!", "Крысы!" };
            //Array.Sort(a);
            //int n1 = 0;
            //foreach (string bagItem in a)
            //{
            //    if (bagItem == "Гады!" || bagItem == "Проститутки!" || bagItem == "Крысы!" || bagItem == "Идиоты!" || bagItem == "Дураки!")
            //    {
            //        n1++;
            //    }
            //}
            //Console.WriteLine($"Имя: {person1.name}, уровень ворчливости: {person1.level_of_grunt}, {n1} - cтолько фингалов бабка");


            //var person2 = new grandfather();
            //person2.name = "Василий";
            //person2.level_of_grunt = 1;
            //string[] b = { "Крысы!", "Идиоты!", "Дураки!" };
            //Array.Sort(b);
            //int n2 = 0;
            //foreach (string bagItem in b)
            //{
            //    if (bagItem == "Гады!" || bagItem == "Проститутки!" || bagItem == "Крысы!" || bagItem == "Идиоты!" || bagItem == "Дураки!")
            //    {
            //        n2++;
            //    }
            //}
            //Console.WriteLine($"Имя: {person2.name}, уровень ворчливости: {person2.level_of_grunt}, {n2} - cтолько фингалов бабка");

            //var person3 = new grandfather();
            //person3.name = "Василий";
            //person3.level_of_grunt = 1;
            //string[] c = { "Идиоты!", "Дураки!" };
            //Array.Sort(c);
            //int n3 = 0;
            //foreach (string bagItem in c)
            //{
            //    if (bagItem == "Гады!" || bagItem == "Проститутки!" || bagItem == "Крысы!" || bagItem == "Идиоты!" || bagItem == "Дураки!")
            //    {
            //        n3++;
            //    }
            //}
            //Console.WriteLine($"Имя: {person3.name}, уровень ворчливости: {person3.level_of_grunt}, {n3} - cтолько фингалов бабка");

            //var person4 = new grandfather();
            //person4.name = "Василий";
            //person4.level_of_grunt = 1;
            //string[] d = { "Проститутки!" };
            //Array.Sort(d);
            //int n4 = 0;
            //foreach (string bagItem in d)
            //{
            //    if (bagItem == "Гады!" || bagItem == "Проститутки!" || bagItem == "Крысы!" || bagItem == "Идиоты!" || bagItem == "Дураки!")
            //    {
            //        n4++;
            //    }
            //}
            //Console.WriteLine($"Имя: {person4.name}, уровень ворчливости: {person4.level_of_grunt}, {n4} - cтолько фингалов бабка");

            //var person5 = new grandfather();
            //person5.name = "Василий";
            //person5.level_of_grunt = 1;
            //string[] e = { "Гады!", "Проститутки!", "Идиоты!", "Дураки!" };
            //Array.Sort(e);
            //int n5 = 0;
            //foreach (string bagItem in e)
            //{
            //    if (bagItem == "Гады!" || bagItem == "Проститутки!" || bagItem == "Крысы!" || bagItem == "Идиоты!" || bagItem == "Дураки!")
            //    {
            //        n5++;
            //    }
            //}
            //Console.WriteLine($"Имя: {person5.name}, уровень ворчливости: {person5.level_of_grunt}, {n5} - cтолько фингалов бабка");

            Console.WriteLine("Задача 7");
            ////Написать метод Быстрой сортировки массива(Быстрая сортировка - название сортировки)
            Console.WriteLine("До сортровки: ");
            Random random1 = new Random();
            double[] nums = new double[10];
            Random random2 = new Random();
            for (int a = 0; a < 10; a++)
            {
                nums[a] = random2.Next(0, 100);
            }
            foreach (int a in nums)
                Console.Write(a + " ");
            SpeedSorting(nums, 0, nums.Length - 1);
            Console.WriteLine("\nПосле сортировки: ");
            foreach (int a in nums)
                Console.Write(a + " ");
            Console.ReadKey();
        }
    }
}
