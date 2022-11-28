using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_10
{
    abstract class Figure : IMove, IChangeColor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Сolor { get; set; }
        public string Сondition { get; set; }
        public abstract void ColorChange();

        public abstract void MyCondition();
        public abstract double Square();
        public void MoveX(int t)
        {
            X += t;
        }
        public void MoveY(int t)
        {
            Y += t;
        }
        public abstract void Print();
    }
}
