using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    //class Person
    //{
    //    public string name = "Undefined";
    //    public int age;

    //    public void Print()
    //    {
    //        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    //    }
    //}
    class Building
    {
        private string number = "0";
        public string Number
        {
            get {  return number;  }
            set {  number = value; }
        }
        private float height = 0;
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        private int floors = 0;
        public int Floor
        {
            get { return floors; }
            set { floors = value; }
        }
        private int flats = 0;
        public int Flat
        {
            get { return flats; }
            set { flats = value; }
        }
        private int entrances = 0;
        public int Entrance
        {
            get { return entrances; }
            set { entrances = value; }
        }
        public override string ToString() => $": {Number}\n: {Height}\nТип счета: {Floor}\n{Flat}\n{Entrance}";
    }
    class Program
    {
        static void Main()
        {
            //Person tom = new Person();  // создание объекта класса Person

            //// Получаем значение полей в переменные
            //string personName = tom.name;
            //int personAge = tom.age;
            //Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0

            //// устанавливаем новые значения полей
            //tom.name = "Tom";
            //tom.age = 37;

            //// обращаемся к методу Print
            //tom.Print();

            Building building = new Building();
            Console.WriteLine("Номер дома, высота, этажность, квартиры, подъезды: ");
            building.Number = Console.ReadLine();
            string number = building.Number;
            building.Height = float.Parse(Console.ReadLine());
            float height = building.Height;
            building.Floor = int.Parse(Console.ReadLine());
            int floors = building.Floor;
            building.Flat = int.Parse(Console.ReadLine());
            int flats = building.Flat;
            building.Entrance = int.Parse(Console.ReadLine());
            int entrances = building.Entrance;
            Console.WriteLine(building);  
            //Реализовать класс для описания здания
            //(уникальный номер здания, высота, этажность, количество квартир, подъездов).
            //Поля сделать закрытыми, предусмотреть методы для заполнения полей и
            //получения значений полей для печати. Добавить методы вычисления высоты этажа,
            //количества квартир в подъезде, количества квартир на этаже и т.д.
            //Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
            //Для этого в классе предусмотреть статическое поле, которое бы хранило
            //последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.
        }
    }
    
}
