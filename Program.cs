using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            ICipher cipher;
            ACipher aCipher = new ACipher();
            cipher = aCipher; // ссылаемся на объект класса шифр
            Console.Write("а) ");
            string stroka = "ABCDEFJ";
            string coded = cipher.encode(stroka);// метод зашифровывающий сроку
            Console.WriteLine($"Шифр: {coded}");
            string incoded = cipher.decode(stroka); // метод расшифровывающий строку
            Console.WriteLine($"Расшифрованный код: {incoded}");

            BCipher bCipher = new BCipher();
            cipher = bCipher;
            Console.Write("б) ");
            string predl1 = "абвг";
            string coded2 = cipher.encode(predl1);
            Console.WriteLine($"Закодирован: {coded2}");
            string incoded2 = cipher.decode(predl1);
            Console.WriteLine($"Расшифрован: {incoded2}");

            Console.WriteLine("Домашнее задание 10.1");
            Circle circle = new Circle();
            circle.Square();
            circle.ColorChange();
            circle.MyCondition();
            circle.MoveX(4);
            circle.MoveY(4);
            circle.Print();
            Rectangle rectangle = new Rectangle();
            rectangle.Square();
            rectangle.ColorChange();
            rectangle.MyCondition();
            rectangle.MoveX(4);
            rectangle.MoveY(4);
            rectangle.Print();
            Point point = new Point();
            point.Square();
            point.ColorChange();
            point.MyCondition();
            point.MoveX(4);
            point.MoveY(4);
            point.Print();
        }
    }
}
