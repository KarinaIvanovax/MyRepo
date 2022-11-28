using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Rectangle : Point
    {
        int width;
        int higth;
        public override double Square()//вычисляет площадь прямоугольника
        {
            Console.WriteLine("Введите ширину:");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину:");
            higth = int.Parse(Console.ReadLine());
            double plosh2 = width * higth;
            Console.WriteLine($"Площадь прямоугольника: {plosh2}");
            return plosh2;
        }
        public override void ColorChange()
        {
            Color = "Red";
        }
        public override void MyCondition()
        {
            Condition = "Видимое";
        }
        public override void Print()
        {
            Console.WriteLine($"Параметры фигуры: \nПередвижение фигуры: ({X} , {Y})\nЦвет: {Color}\nСостояние: {Condition}\n");
        }
    }
}
