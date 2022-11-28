using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Circle : Point
    {
        public int r;//радиус 
        public override double Square()//вычисляет площадь окружности
        {
            Console.WriteLine("Введите радиус круга:");
            r = int.Parse(Console.ReadLine());
            double plosh = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь круга: {plosh}");
            return plosh;
        }
        public override void ColorChange()
        {
            Color = "Blue";
        }
        public override void MyCondition()
        {
            Condition = "Видимое";
        }
        public override void Print()
        {
            Console.WriteLine($"Параметры фигуры: \nПередвижение фигуры: ({X} , {Y})\nЦвет фигуры: {Color}\nСостояние: {Condition}\n");
        }
    }
}
