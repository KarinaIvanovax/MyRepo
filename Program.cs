using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_ot_17._09._22
{
   /* struct Student 
    {
        public int age; 
        public string firstName; 
        public string secondName;
        public string category;
        public int alcohollevel;
    }*/
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Задача 1");
            // var person1 = new Student();
            // person1.age = 21;
            // person1.firstName = "Владислав";
            // person1.secondName = "Дубин";
            // person1.category = "Алкоголик";
            // Random rnd = new Random();
            // int alcohollevel1 = rnd.Next(0, 100);
            // Console.WriteLine($"Студент А\nИмя: {person1.firstName}\nФамилия: {person1.secondName}\nВозраст: {person1.age}\nСтепень алкоголизма: {person1.category}\nУровень алкоголя: {alcohollevel1}");
            // Console.WriteLine("");
            // var person2 = new Student();
            // person2.age = 19;
            // person2.firstName = "Камилла";
            // person2.secondName = "Зайцева";
            // person2.category = "Любитель выпить, но не алкоголик";
            // int alcohollevel2 = rnd.Next(0, 100);
            // Console.WriteLine($"Студент B\nИмя: {person2.firstName}\nФамилия: {person2.secondName}\nВозраст: {person2.age}\nСтепень алкоголизма: {person2.category}\nУровень алкоголя: {alcohollevel2}");
            // Console.WriteLine("");
            // var person3 = new Student();
            // person3.age = 18;
            // person3.firstName = "Андрей";
            // person3.secondName = "Васильев";
            // person3.category = "Студент пьет по праздникам";
            // int alcohollevel3 = rnd.Next(0, 100);
            // Console.WriteLine($"Студент C\nИмя: {person3.firstName}\nФамилия: {person3.secondName}\nВозраст: {person3.age}\nСтепень алкоголизма: {person3.category}\nУровень алкоголя: {alcohollevel3}");
            // Console.WriteLine("");
            // var person4 = new Student();
            // person4.age = 20;
            // person4.firstName = "Таня";
            // person4.secondName = "Кротова";
            // person4.category = "Студент не пьет ";
            // person4.alcohollevel = 0;
            // Console.WriteLine($"Студент D\nИмя: {person4.firstName}\nФамилия: {person4.secondName}\nВозраст: {person4.age}\nСтепень алкоголизма: {person4.category}\nУровень алкоголя: {person4.alcohollevel}");
            // Console.WriteLine("");
            // var person5 = new Student();
            // person5.age = 17;
            // person5.firstName = "Регина";
            // person5.secondName = "Сидорова";
            // person5.category = "Студент пьет по праздникам";
            // int alcohollevel5 = rnd.Next(0, 100);
            // Console.WriteLine($"Студент E\nИмя: {person5.firstName}\nФамилия: {person5.secondName}\nВозраст: {person5.age}\nСтепень алкоголизма: {person5.category}\nУровень алкоголя: {alcohollevel5}");

            // var alcohollevel = alcohollevel1 + alcohollevel2 + alcohollevel3 + person4.alcohollevel + alcohollevel5;
            // Console.WriteLine($"Общий уровень алкоголя = {alcohollevel}");
            //Console.ReadKey();

            //Console.WriteLine("Задача 2");
            //Console.WriteLine("Типы данных");
            //Console.WriteLine("bool:хранит значения true и false ");
            //Console.WriteLine("Целочисленные типы данных");
            //Console.Write("byte min: ");
            //Console.WriteLine((int)byte.MinValue);
            //Console.Write("byte max: ");
            //Console.WriteLine((int)byte.MaxValue);
            //Console.Write("sbyte min: ");
            //Console.WriteLine((int)sbyte.MinValue);
            //Console.Write("sbyte max: ");
            //Console.WriteLine((int)sbyte.MaxValue);
            //Console.Write("short min: ");
            //Console.WriteLine((int)short.MinValue);
            //Console.Write("short max: ");
            //Console.WriteLine((int)short.MaxValue);
            //Console.Write("ushort min: ");
            //Console.WriteLine((int)ushort.MinValue);
            //Console.Write("ushort max: ");
            //Console.WriteLine((int)ushort.MaxValue);
            //Console.Write("int min: ");
            //Console.WriteLine((int)int.MinValue);
            //Console.Write("int max: ");
            //Console.WriteLine((int)int.MaxValue);
            //Console.Write("uint min: ");
            //Console.WriteLine((double)uint.MinValue);
            //Console.Write("uint max: ");
            //Console.WriteLine((double)uint.MaxValue);
            //Console.Write("long min: ");
            //Console.WriteLine((double)long.MinValue);
            //Console.Write("long max: ");
            //Console.WriteLine((double)long.MaxValue);
            //Console.Write("ulong min: ");
            //Console.WriteLine((double)ulong.MinValue);
            //Console.Write("ulong max: ");
            //Console.WriteLine((double)ulong.MaxValue);
            //Console.WriteLine("Типы данных с плавающей точкой");
            //Console.Write("float min: ");
            //Console.WriteLine((double)float.MinValue);
            //Console.Write("float max: ");
            //Console.WriteLine((double)float.MaxValue);
            //Console.Write("double min: ");
            //Console.WriteLine((double)double.MinValue);
            //Console.Write("double max: ");
            //Console.WriteLine((double)double.MaxValue);
            //Console.Write("decimal min: ");
            //Console.WriteLine((decimal)decimal.MinValue);
            //Console.Write("decimal max: ");
            //Console.WriteLine((decimal)decimal.MaxValue);
            //Console.ReadKey();

            /* Console.WriteLine("Задача 3");
             // Напишите программу, в которой принимаются данные пользователя в виде имени,
             // города, возраста и PIN-кода. Далее сохраните все значение в соответствующей переменной,
             // а затем распечатайте всю информацию в правильном формате.
             Console.Write("Введите имя: ");
             string name = Console.ReadLine();
             Console.Write("Введите свой город: ");
             string hometown = Console.ReadLine();
             Console.Write("Введите свой возраст: ");
             var age = Console.ReadLine();
             Console.Write("Введите PIN-код: ");
             var pin = Console.ReadLine();
             Console.Write(" ");
             Console.WriteLine($"Имя: {name}\nГород: {hometown}\nВозраст: {age}\nPIN-код: {pin}");
             Console.ReadKey(); */

            //Console.WriteLine("Задача 4");
            ////Напишите программу, которая преобразует имя в инициалы.
            ////На вход подаются два слова с одним пробелом.
            ////На консоль выводятся 2 заглавные буквы с разделяющий их точкой.
            //Console.Write(" ");
            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Введите фамилию: ");
            //string surname = Console.ReadLine();
            //Console.Write("Введите отчество: ");
            //string fname = Console.ReadLine();
            //string a = name.Remove(1);
            //string b = surname.Remove(1);
            //string c = fname.Remove(1);
            //Console.WriteLine($"{a}.{b}.{c}.");
            //Console.ReadKey(); 

            //Console.WriteLine("Задача 5");
            ////Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить,
            ////чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.
            ////Вам будет предоставлена стандартная цена (normPrice), скидка в DutyFree(salePrice)
            ////и стоимость отпуска (holidayPrice).
            ////Например, если бутылка обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%,
            ////вы сэкономите 1 фунт стерлингов на каждой бутылке.
            ////Если ваш отпуск стоит 500 фунтов стерлингов, ответ, который вы должны вернуть, будет 500.
            ////Все входные данные будут целыми числами.
            ////Пожалуйста, верните целое число. Округлить в меньшую сторону.
            //Console.Write("В магазине бутылка виски (в фунтах) стоит: ");
            //int normPrice = int.Parse(Console.ReadLine());
            //int salePrice = normPrice - normPrice / 10;
            //Console.WriteLine($"Цена в DutyFree: {normPrice - normPrice / 10}");
            //Console.Write("Стоимость вашего отпуска (в фунтах): ");
            //int holidayPrice = int.Parse(Console.ReadLine());
            //int s = holidayPrice / (normPrice / 10);
            //Console.WriteLine($"Столько бутылок виски вам нужно купить, чтобы фактически покрыть расходы на отпуск: {s}");
            //Console.ReadKey();

            //Console.WriteLine("Задача 6");
            ////Таракан - одно из самых быстрых насекомых.
            ////Напишите функцию, которая принимает скорость в км в час и возвращает ее в см в секунду,
            ////округленную до целого числа (= в меньшую сторону). Например: 1,08 -> 30
            //Console.Write("Введите скорость в км/ч: ");
            //double vh = double.Parse(Console.ReadLine());
            //double vsec = vh * 100000 / 3600;
            //Console.WriteLine($"См/сек: {vsec}");
            //Console.ReadKey();

            Console.WriteLine("Задача 7");
            //Преобразуйте входную строку: строчные буквы – в заглавные, заглавные – в строчные.
            string message;
            Console.Write("Введите слово: ");
            message = Console.ReadLine();
            message = string.Concat(message.Select(c => (char)(char.ToLower(c) ^ char.ToUpper(c) ^ c)));
            Console.WriteLine("Полученная строка " + message);
            Console.ReadKey();




        }
    }
}
