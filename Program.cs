using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project
{
    struct Animal
    {
        //public string Name { get; set; }
        //public string Class { get; set; }
        //public string Country { get; set; }
        //public string Nutrition { get; set; }
        //public void PrintAnimalChar()
        //{
        //    Console.WriteLine($"Название: {Name}, Класс: {Class}, Обитает в {Country}, Питается {Nutrition}");
        //}
    }
    abstract class Animals
    {
        //public string Name { get; set; }
        //public string Class { get; set; }
        //public string Country { get; set; }
        //public string Nutrition { get; set; }
        //public Animals(string name, string classA, string country, string nutrition)
        //{
        //    Name = name;
        //    Class = classA;
        //    Country = country;
        //    Nutrition = nutrition;
        //}
        //public void PrintCharacteristic()
        //{
        //    Console.WriteLine(Name, Class, Country, Nutrition);
        //}
        private string name = " ";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string classA = " ";
        public string Class
        {
            get { return classA; }
            set { classA = value; }
        }
        private string country = " ";
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string nutrition = " ";
        public string Nutrition
        {
            get { return nutrition; }
            set { nutrition = value; }
        }
        public override string ToString() => $": {Name}\n: {Class}\n {Country}\n{Nutrition}\n";
        //public void Animal()
        //{
        //    Console.WriteLine(" ");
        //    Animal animal = new Animal();
        //    animal.Name = "Заменить через get set";
        //    animal.Class = "get set";
        //    animal.Country = "get set";
        //    animal.Nutrition = "get set";

        //}
    }
    class Insects : Animals
    {
        public void PrintInsects()
        {
            Insects a = new Insects();
            a.Name = "Божья коровка";
            string name = a.Name;
            a.Class = "Насекомые";
            string classA = a.Class;
            a.Country = "Россия";
            string country = a.Country;
            a.Nutrition = "тля";
            string nutrition = a.Nutrition;
            Console.WriteLine(a);
        }
    }
    class Mammals : Animals
    {
        public void PrintMammals()
        {
            Mammals squirrel = new Mammals();
            squirrel.Name = "Белка";
            string name = squirrel.Name;
            squirrel.Class = "Млекопитающие";
            string classA = squirrel.Class;
            squirrel.Country = "Россия";
            string country = squirrel.Country;
            squirrel.Nutrition = "Орешки";
            string nutrition = squirrel.Nutrition;
            Console.WriteLine(squirrel);
        }

    }
    class Fish : Animals 
    {
        public void PrintFish()
        {
            Fish a = new Fish();
            a.Name = "Карп Кои";
            string name = a.Name;
            a.Class = "Рыбы";
            string classA = a.Class;
            a.Country = "Япония";
            string country = a.Country;
            a.Nutrition = "Моллюски, креветки";
            string nutrition = a.Nutrition;
            Console.WriteLine(a);
        }
    }
    class Reptiles : Animals 
    {
        public void PrintReptiles()
        {
            Reptiles a = new Reptiles();
            a.Name = "Красноухая черепаха";
            string name = a.Name;
            a.Class = "Пресмыкающиеся";
            string classA = a.Class;
            a.Country = "Америка";
            string country = a.Country;
            a.Nutrition = "мелкая рыба, мальки";
            string nutrition = a.Nutrition;
            Console.WriteLine(a);
        }
    }
    class Birds : Animals 
    {
        public void PrintBirds()
        {
            Birds a = new Birds();
            a.Name = "Зяблик";
            string name = a.Name;
            a.Class = "Птицы";
            string classA = a.Class;
            a.Country = "Россия";
            string country = a.Country;
            a.Nutrition = "семена";
            string nutrition = a.Nutrition;
            Console.WriteLine(a);
        }
    }
    class BotanicalGarden
    {
        public void PrintHeader()
        {
            Console.WriteLine("Добро пожаловать на страницу ботанического сада! Какие вопросы Вас интересуют?");
            Console.WriteLine("1. График работы;\n2. Цена билета;\n3. Как добраться;\n4. О ботаническом саде\nВведите цифру в соответствии с интересующим Вас вопросом.");

        }
    }
    class Hours
    {
        public void PrintHours()
        {
            Console.WriteLine("График работы");
        }
    }
    class Price
    {
        public void PrintPrice()
        {
            Console.WriteLine("Цена билета: что-нибудь написать");
        }
    }
    class Route
    {
        public void PrintRoute()
        {
            Console.WriteLine("Маршрут, адрес");
        }
    }
    class Information
    {
        public void PrintInformation()
        {
            Console.WriteLine("Краткая информация\nХотите узнать больше?");
            string answer1 = Console.ReadLine();
            if (answer1 == "да"|| answer1 == "Да")
            {
                Console.WriteLine("О чем бы Вы хотели узнать?");
                Console.WriteLine("1. Обитатели сада;\n2. Что растет в саду;\n3. История ботанического сада;\n");
                Console.WriteLine("Введите цифру в соответствии с интересующим Вас вопросом.");
                byte question2 = byte.Parse(Console.ReadLine());
                if (question2 == 1)
                {
                    Mammals m = new Mammals();
                    m.PrintMammals();
                    Insects i = new Insects();
                    i.PrintInsects();
                    Reptiles r = new Reptiles();
                    r.PrintReptiles();
                    Birds b = new Birds();
                    b.PrintBirds();
                    Fish f = new Fish();
                    f.PrintFish();
                }
                else if (question2 == 2) { }
                else if (question2 == 3) { }
                else { Console.WriteLine("Ошибка"); }

            }
            else { Console.WriteLine("Пока что завершение программы"); }
        }

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            BotanicalGarden header = new BotanicalGarden();
            header.PrintHeader();
            byte question1 = byte.Parse(Console.ReadLine());
            if (question1 == 1)
            {
                Hours hours = new Hours();
                hours.PrintHours();
            }
            else if (question1 == 2)
            {
                Price price = new Price();
                price.PrintPrice();
            }
            else if (question1 == 3)
            {
                Route route = new Route();
                route.PrintRoute();
            }
            else if (question1 == 4)
            {
                Information information = new Information();
                information.PrintInformation();
            }
            else { Console.WriteLine("Такого запроса не существует"); }


        }
    }
}
