using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задача 12");
             double Striangle = 0.0;
             double SCircle = 0.0;
             double SP = 0.0;
             Console.WriteLine("Выберите фигуру");
             Console.WriteLine("");
             Console.WriteLine("Треугольник => нажмите 1 ");
             Console.WriteLine("Круг => нажмите 2 ");
             Console.WriteLine("Четырехугольник => нажмите 3 ");
             int tmp = int.Parse(Console.ReadLine());
             if (tmp == 1)
             {
                 double STriangle = 0.0;
                 double Ptriangle = 0.0;
                 Console.WriteLine("Площадь => нажмите 1 ");
                 Console.WriteLine("Периметр => нажмите 2 ");
                 int tm = int.Parse(Console.ReadLine());
                 if (tm == 1)
                 {
                     Console.Write("Введите a: ");
                     string a = Console.ReadLine();
                     Console.Write("Введите h: ");
                     string h = Console.ReadLine();
                     STriangle = Convert.ToDouble(a) * Convert.ToDouble(h) / 2;
                     Console.WriteLine($"Площадь треугольника = {STriangle}");
                 }
                 else if (tm == 2)
                 {
                     Console.Write("Введите a: ");
                     string a = Console.ReadLine();
                     Console.Write("Введите b: ");
                     string b = Console.ReadLine();
                     Console.Write("Введите c: ");
                     string c = Console.ReadLine();
                     double PT = Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);
                     Console.WriteLine($"Периметр треугольника = {PT}");
                 }
                 else
                 {
                     Console.WriteLine("Error");
                 }

             }
             else if (tmp == 2)
             {
                 double Scircle = 0.0;
                 double Pcircle = 0.0;
                 Console.WriteLine("Периметр => нажмите 1 ");
                 Console.WriteLine("Площадь => нажмите 2 ");
                 int t = int.Parse(Console.ReadLine());
                 if (t == 1)
                 {
                     Console.Write("Введите R: ");
                     string R = Console.ReadLine();
                     double Pcir = 2 * Math.PI * Convert.ToDouble(R);
                     Console.WriteLine($"Периметр круга = {Pcir}");
                 }
                 else if (t == 2)
                 {
                     Console.Write("Введите значение радиуса: ");
                     string R = Console.ReadLine();
                     SCircle = Math.PI * Math.Pow(Convert.ToDouble(R), 2);
                     Console.WriteLine($"Площадь круга = {SCircle}");
                 }
                 else
                 {
                     Console.WriteLine("Error");
                 }

             }

             else if (tmp == 3)
             {
                 double SQuad = 0.0;
                 double PQuad = 0.0;
                 Console.WriteLine("Периметр => нажмите 1 ");
                 Console.WriteLine("Площадь => нажмите 2 ");
                 int t = int.Parse(Console.ReadLine());
                 if (t == 1)
                 {
                     Console.Write("Введите a: ");
                     string a = Console.ReadLine();
                     Console.Write("Введите b: ");
                     string b = Console.ReadLine();
                     double PQ = Convert.ToDouble(a) * 2 + Convert.ToDouble(b) * 2;
                     Console.WriteLine($"Периметр четырехугольника = {PQ}");
                 }
                 else if (t == 2)
                 {
                     Console.Write("Введите a: ");
                     string a = Console.ReadLine();
                     Console.Write("Введите b: ");
                     string b = Console.ReadLine();
                     double SQ = Convert.ToDouble(a) * Convert.ToDouble(b);
                     Console.WriteLine($"Площадь четырехугольника = {SQ}");
                 }
                 else
                 {
                     Console.WriteLine("Error");
                 }
             }

             else
             {
                 Console.WriteLine("Error");
             }
             Console.WriteLine("Конец программы");
             Console.ReadKey();*/

            Console.WriteLine("Задача 11");
            Console.Write("Введите 1 число: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double c = firstNumber;
            firstNumber = secondNumber; secondNumber = c;
            Console.WriteLine($"Число 1 = {firstNumber}, число 2 = {secondNumber}");
            Console.Clear();
        }
    }
}
