using System;
using System.Text;

namespace home


{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Задача 1. Вывести на экран значение e ");
             Console.WriteLine(Math.Round(Math.E, 1));*/


            //вывод чисел столбиком (50 и 10)
            /*Console.WriteLine("Задача 2. Вывести 50 b 10 ");
            int a = 50, b = 10;
            Console.WriteLine($"{a}\n{b}");*/

            //вывод 4 любых чисел столбиком.3 
            /*Console.WriteLine("Задача 3");
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);
            int d = rnd.Next(0, 100);
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");*/

            //вывод числа на 10 больше напечатанного
            /*Console.WriteLine("Задача 4");
            Console.Write("Введите число ");
            double a = double.Parse(Console.ReadLine());
            double b = a + 10;
            Console.Write(b);*/

            //нахождение периметра квадрата
            /* Console.WriteLine("Задача 5");
             Console.Write("Сторона квадрата: ");
             double a = double.Parse(Console.ReadLine());
             double p = 4 * a;
             Console.WriteLine($"Периметр: {p}");*/

            //нахождение длины окружности и площади круга
            /*Console.WriteLine("Задача 6");
            Console.Write("Введите значение радиуса ");
            double R = double.Parse(Console.ReadLine());
            double L = 2 * 3.14 * R;
            double S = 3.14 * Math.Pow(R, 2);
            Console.WriteLine($"L = {L}; S = {S}");
            Console.ReadKey();*/

            //нахождение периметра равнобедренной трапеции
            /*Console.WriteLine("Задача 8");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Нахождение периметра");

            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());

            var c1 = Math.Pow((a / 2 - b / 2), 2) + Math.Pow(h, 2);
            var c = Math.Pow(c1, 0.5);
            var d = c;

            var P = a + b + c + d;
            Console.WriteLine($"Периметр равнобедренной трапеции = {a + b + c + d}");
            Console.ReadKey();*/


            //решение задачи на кг конфет, печенья, яблок
            /*Console.WriteLine("Задача 9");
            Console.WriteLine("Решение задачи на кг");
            Console.Write("1 кг конфет стоит ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("1 кг печенья стоит ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("1 кг яблок стоит ");
            var c = double.Parse(Console.ReadLine());

            Console.Write("Сколько кг конфет взяли ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("Сколько кг печенья взяли ");
            var y = double.Parse(Console.ReadLine());
            Console.Write("Сколько кг яблок взяли ");
            var z = double.Parse(Console.ReadLine());

            var x1 = a * x;
            var y1 = b * y;
            var z1 = c * z;

            var S = x1 + y1 + z1;
            Console.WriteLine($"Сумма покупки составит {x1 + y1 + z1}");
            Console.ReadKey();*/


            //мир труд май
            /*Console.WriteLine("Задача 10");
            Console.WriteLine("Мир Труд Май");
            var a = ("Мир");
            var b = ("Труд");
            var c = ("Май");
            Console.WriteLine($"{a}\n   {b}\n         {c}\n");*/

            //ввести два числа и поменять их местами
            /* Console.WriteLine("Задача 11");
             Console.Clear();
             int a = 0, b = 0;
             bool ba = false, bb = false, ba1 = false, bb1 = false;
             double a1 = 0, b1 = 0;

             Console.WriteLine("Задача: ввести два числа");
             Console.Write("Введите число 1: ");
             string firstdigit = Console.ReadLine();

             //если пользователь использует "." или "," при записи десятичных дробей
             if (firstdigit != null && firstdigit.Contains(",") || firstdigit != null && firstdigit.Contains("."))
             {

                 if (double.TryParse(firstdigit, out a1))//дробь
                 {
                     a1 = Convert.ToDouble(firstdigit);

                     Console.WriteLine(string.Format("Вы ввели первым: {0}", a1));

                     ba1 = true;
                 }
                 else
                 {
                     Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
                     Console.Write("введите число 1: ");
                     Console.ReadLine();
                 }
             }
             else// простые числа
             {
                 if (int.TryParse(firstdigit, out a))//простое число
                 {
                     Console.WriteLine(string.Format("Вы ввели первым: {0}", a));
                     ba = true;
                 }
                 else// это не простое число
                 {
                     Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры ");
                     Console.Write("введите число 1: ");
                     Console.ReadLine();
                 }
             }


             Console.Write("Введите число 2: ");
             string secondigit = Console.ReadLine();

             //повтор операций с числом 2
             //если пользователь использует "." или "," при записи десятичных дробей
             if (secondigit != null && secondigit.Contains(",") || secondigit != null && secondigit.Contains("."))
             {
                 if (secondigit.Contains("."))
                 {
                     secondigit = secondigit.Replace(',', '.');
                 }
                 if (double.TryParse(secondigit, out b1))//дробь
                 {
                     b1 = Convert.ToDouble(secondigit);
                     Console.WriteLine(string.Format("Вы ввели вторым:  {0}", b1));
                     bb1 = true;
                 }
                 else
                 {
                     Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
                     Console.Write("введите число 2: ");
                     Console.ReadLine();
                 }
             }
             else//простые числа
             {
                 if (int.TryParse(secondigit, out b))//простое число
                 {
                     Console.WriteLine(string.Format("Вы ввели вторым: {0}", b));
                     bb = true;
                 }
                 else//не простое число
                 {
                     Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
                     Console.Write("введите число ");
                     Console.ReadLine();
                 }
             }
             if (ba && bb)
             {
                 Console.WriteLine(string.Format("Результат: {0} {1}", b, a));
             }
             if (ba1 && bb1)
             {
                 Console.WriteLine(string.Format("Результат: {0} {1}", b1, a1));
             }
             if (ba && bb1)
             {
                 Console.WriteLine(string.Format("Результат: {0} {1}", b1, a));
             }
             if (ba1 && bb)
             {
                 Console.WriteLine(string.Format("Результат: {0} {1}", b, a1));
             }

             Console.WriteLine("Если хотите продолжить, нажмите любую клавишу ");
             var line = Console.ReadLine();
             int choice;
             if (int.TryParse(line, out choice) == false)
             {
                 Console.Clear();
                 Console.WriteLine("До свидания!");
             }*/

            /*Console.WriteLine("Задача 12");
            Console.WriteLine("Выберите фигуру");
            Console.WriteLine("");
            Console.WriteLine("Треугольник => нажмите 1 ");
            Console.WriteLine("Круг => нажмите 2 ");
            Console.WriteLine("Четырехугольник => нажмите 3 ");

            var line = Console.ReadLine();
            int choice2;
            if (int.TryParse(line, out choice2) == false)
            {
                Console.Clear();
                Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
            }
            else
            {
                switch (choice2)
                {
                    case 1://треугольник
                        {
                            Console.WriteLine("Вы выбрали треугольник ");
                            Console.WriteLine("");

                            Console.WriteLine("Чтобы посчитать площадь, нажмите 1 ");
                            Console.WriteLine("Чтобы посчитать периметр, нажмите 2 ");

                            if (int.TryParse(line, out choice2) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
                            }

                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Площадь =1/2*a*h");
                                        Console.Write("Введите a: ");
                                        var a = Console.ReadLine();
                                        Console.Write("Введите h: ");
                                        var h = Console.ReadLine();
                                        double result = 0.5 * Convert.ToDouble(a) * Convert.ToDouble(h);

                                        Console.WriteLine(string.Format("Площадь =1/2*{a}*{h}={result}", a, h, result));

                                        //площадь
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Периметр =a+b+c");
                                        Console.Write("Введите a: ");
                                        var a = Console.ReadLine();
                                        Console.Write("Введите b: ");
                                        var b = Console.ReadLine();
                                        Console.Write("Введите с: ");
                                        var c = Console.ReadLine();

                                        double result = Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);

                                        Console.WriteLine(string.Format("Периметр={a}+{b}+{c}={result}", a, b, c, result));
                                        //тут должен считаться периметр
                                    }
                                    break;
                            }

                        }
                        break;

                    case 2://круг
                        {
                            Console.WriteLine("Вы выбрали круг ");
                            Console.WriteLine("");

                            Console.WriteLine("Чтобы посчитать площадь, нажмите 1 ");
                            Console.WriteLine("Чтобы посчитать периметр, нажмите 2 ");

                            if (int.TryParse(line, out choice2) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
                            }

                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Площадь=Pir^2");
                                        Console.Write("Введите значение радиуса: ");
                                        var R = Console.ReadLine();

                                        double result = Math.PI * Math.Pow (Convert.ToDouble(R), 2);

                                        Console.WriteLine(string.Format("Периметр=3.14*{R}^2={result}", R, result));

                                        //плошадь
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Периметр=2PiR");
                                        Console.Write("Введите значение радиуса: ");
                                        var R = Console.ReadLine();

                                        double result = 2 * Math.PI * Convert.ToDouble(R);

                                        Console.WriteLine(string.Format("Периметр=2*3.14*{R}={result}", R, result));

                                        //периметр
                                    }
                                    break;
                            }
                        }
                        break;

                    case 3://четырехугольник
                        {
                            Console.WriteLine("Вы выбрали прямоугольный четырехугольник ");
                            Console.WriteLine("");

                            Console.WriteLine("Чтобы посчитать площадь, нажмите 1 ");
                            Console.WriteLine("Чтобы посчитать периметр, нажмите 2 ");

                            if (int.TryParse(line, out choice2) == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Введены неверные данные, попробуйте снова, используя только цифры");
                            }

                            switch (choice2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Площадь =a*b");
                                        Console.Write("Введите a: ");
                                        var a = Console.ReadLine();
                                        Console.Write("Введите b: ");
                                        var b = Console.ReadLine();
                                        double result = Convert.ToDouble(a) * Convert.ToDouble(b);

                                        Console.WriteLine(string.Format("Площадь ={a}*{b}={result}", a, b, result));

                                        //плошадь
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Периметр =2*(a+b)");
                                        Console.Write("Введите a: ");
                                        var a = Console.ReadLine();
                                        Console.Write("Введите b: ");
                                        var b = Console.ReadLine();

                                        double result = Convert.ToDouble(a)*2 + Convert.ToDouble(b)*2;

                                        Console.WriteLine(string.Format("Периметр={a}*2+{b}*2={result}", a, b, result));
                                        //периметр
                                    }
                                    break;
                            }
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Конец программы");
                            Console.ReadLine();
                        }
                        break;


                }
            }*/

            //вывод числа с надписью
            /*Console.WriteLine("Задача 13");
             Console.Write("Введите число ");
             var a = double.Parse(Console.ReadLine());
             Console.WriteLine($"Вы ввели число {a}");
             Console.ReadKey();*/

            //вывод на экран 2 кг 13 17
            /*Console.WriteLine("Задача 14");
             Console.WriteLine("2  кг\n13 17");
             Console.ReadKey();*/

            //вывод 4 любых чисел столбиком
            /*Console.WriteLine("Задача 15");
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);
            int d = rnd.Next(0, 100);
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");*/

            //квадратное уравнение
            /* Console.WriteLine("Задача 16");
             Console.OutputEncoding = Encoding.UTF8;
             Console.WriteLine("Решение квадратного уравнения");
             //ввод данных
             Console.Write("a = ");
             var a = double.Parse(Console.ReadLine());
             Console.Write("b = ");
             var b = double.Parse(Console.ReadLine());
             Console.Write("c = ");
             var c = double.Parse(Console.ReadLine());

             //дискриминант
             double x1, x2;
             var discriminant = Math.Pow(b, 2) - 4 * a * c;
             if (discriminant < 0)
             {
                 Console.WriteLine("Уравнение не имеет корней");
             }
             else if (discriminant == 0) //уравнение будет иметь два одинаковых корня
             {
                 x1 = -b / (2 * a);
                 x2 = x1;
             }
             else if (discriminant > 0) //уравнение будет иметь два разных корня
             {
                 x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                 x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
             }
             //вывод корней уравнения
             Console.WriteLine($"x1 = {(-b + Math.Sqrt(discriminant)) / (2 * a)}; x2 = {(-b - Math.Sqrt(discriminant)) / (2 * a)}");*/

            //среднее арифметическое и среднее геометрическое
            /* Console.WriteLine("Задача 17");
             Console.WriteLine("Введите числa");
             Console.Write("a = ");
             var a = double.Parse(Console.ReadLine());
             Console.Write("b = ");
             var b = double.Parse(Console.ReadLine());
             Console.WriteLine("Среднее арифметическое: " + (double)((a + b)*0.5));
             Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(a * b));
             Console.ReadKey();*/

            /* Console.WriteLine("Задача 18. Расстояние между точками");
             Console.Write("Введите координаты x1: ");
             var x1 = double.Parse(Console.ReadLine());

             Console.Write("Введите координаты x2: ");
             var x2 = double.Parse(Console.ReadLine());

             Console.Write("Введите координаты y1: ");
             var y1 = double.Parse(Console.ReadLine());

             Console.Write("Введите координаты y2: ");
             var y2 = double.Parse(Console.ReadLine());

             double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
             Console.WriteLine($"Расстояние между двумя точками на плоскости равно {result}");
             Console.ReadKey();*/

            //обмен данными
            /*Console.WriteLine("Задача 19.a");
            Console.WriteLine("Введите данные");
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Данные меняются местами");
            Console.WriteLine($"a = {b}\nb = {c}\nc = {a}");
            Console.ReadKey();*/

            /*Console.WriteLine("Задача 19.б");
            Console.WriteLine("Введите данные");
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Данные меняются местами");
            Console.WriteLine($"a = {c}\nb = {a}\nc = {b}");
            Console.ReadKey();*/

            //с начала суток прошло n секунд
            /*Console.WriteLine("Задача 20.а. Количество полных часов с начала суток");
            Console.WriteLine("n - количество секунд");
            Console.WriteLine("Введите значение n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int b = n / 3600;
            Console.WriteLine($"Столько часов прошло с начала суток = {n / 3600}");
            Console.ReadKey();*/

            /*Console.WriteLine("Задача 20.б. Количество полных минут с начала часа");
            Console.WriteLine("n - количество секунд");
            Console.WriteLine("Введите значение n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int b = n / 60;
            if (b > 1)
            {
                double c = n / 60;
                double d = c - b;

                Console.WriteLine($"Столько минут прошло с начала часа = {c - b}");
            }

            Console.WriteLine($"Столько минут прошло с начала часа = {b}");
            Console.ReadKey();*/

            /* Console.WriteLine("Задача 20.в. Количество полных часов с начала суток");
             Console.WriteLine("n - количество секунд");
             Console.WriteLine("Введите значение n");
             Console.Write("n = ");
             int n = int.Parse(Console.ReadLine());
             int g = n / 60;
             if (n > 59)
             {
                 int k = n / 60;
                 int h = 60 * k;
                 double c = n - h;

                 Console.WriteLine($"Столько секунд прошло с начала минуты = {n - h}");

             }
             else if (n < 60)
             {
                 int b = n;
                 Console.WriteLine($"Столько секунд прошло с начала минуты = {n}");

             }
             Console.WriteLine("Конец");*/

            //сколько квадратов можно вырезать
            /*Console.WriteLine("Задача 21");
            Console.WriteLine("Сколько квадратов со стороной 130мм можно вырезать из листа размером 543 x 130мм?");
            Console.Write("Нажмите 1, чтобы узнать ");
            double v = double.Parse(Console.ReadLine());
            int a = 543, b = 130;
            int c = a / b;
            Console.WriteLine($"Столько квадратов можно вырезать = {a / b}");
            Console.ReadKey();*/

            /*Console.WriteLine("Задача 3");
            Random rnd = new Random();
            int a = rnd.Next(1, 9);
            int b = rnd.Next(1, 9);
            int c = rnd.Next(1, 9);
            Console.WriteLine($"Сгенерировалось число {a}{b}{c} ");
            Console.WriteLine("Ответ меняется");
            Console.WriteLine($"Ответ {c}{a}{b} ");
            Console.ReadKey();*/

            /* Console.WriteLine("Задача 23.a. Число сотен");
             Console.WriteLine("Введите значение n");
             Console.WriteLine("n > 999");
             Console.Write("n = ");
             int n = int.Parse(Console.ReadLine());
             int b = n / 100;
             Console.WriteLine($"Столько сотен в числе n = {n / 100}");
             Console.ReadKey();*/

            /* Console.WriteLine("Задача 23.б. Число тысяч");
             Console.WriteLine("Введите значение n");
             Console.WriteLine("n > 999");
             Console.Write("n = ");
             int n = int.Parse(Console.ReadLine());
             int b = n / 1000;
             Console.WriteLine($"Столько сотен в числе n = {n / 1000}");
             Console.ReadKey();*/

            /*Console.WriteLine("Задача 24.a.Число, полученное при прочтении его цифр справа налево ");
            Random rnd = new Random();
            int a = rnd.Next(1, 9);
            int b = rnd.Next(1, 9);
            int c = rnd.Next(1, 9);
            int d = rnd.Next(1, 9);
            Console.WriteLine($"Сгенерировалось число {a}{b}{c}{d} ");
            Console.WriteLine($"Обратное ему число получилось {d}{c}{b}{a}");
            Console.ReadKey();*/

            /*Console.WriteLine("Задача 24.б.Число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784 ");
            Random rnd = new Random();
            int a = rnd.Next(1, 9);
            int b = rnd.Next(1, 9);
            int c = rnd.Next(1, 9);
            int d = rnd.Next(1, 9);
            Console.WriteLine($"Сгенерировалось число {a}{b}{c}{d} ");
            Console.WriteLine($"Перестановка элементов {b}{a}{d}{c}");
            Console.WriteLine($"Без одного элемента {a}{c}{d}");
            Console.ReadKey();*/

            //Из трехзначного числа x вычли его последнюю цифру.
            //Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось число n.
            //Найти число x.Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.

            /* Console.WriteLine("Задача 25");
             Console.WriteLine("Введите значение n");
             Console.WriteLine("100<n<999");
             Console.WriteLine("Десяток числа n не равен нулю");
             Console.Write("Сотен ");
             int a = int.Parse(Console.ReadLine());
             Console.Write("Десятков ");
             int b = int.Parse(Console.ReadLine());
             Console.Write("Единиц ");
             int c = int.Parse(Console.ReadLine());
             Console.WriteLine($"Вы ввели {a}{b}{c}");
             Console.WriteLine($"Изначально было число {b}{c}{a}");
             Console.ReadKey(); */

            //Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени:
            //«h часов, m минут, s секунд». Определить угол(в градусах)
            //между положением часовой стрелки в начале суток и в указанный момент времени.
            /* Console.WriteLine("Задача 26");
             Random rnd = new Random();
             double a = rnd.Next(0, 23);
             double b = rnd.Next(0, 59);
             double c = rnd.Next(0, 59);
             Console.WriteLine($"Сгенерировалось время {a}:{b}:{c} ");
             double x = (a + b / 60 + c / 3600) * 360 / 24;
             Console.WriteLine($"Градусы: {x}");
             Console.ReadKey();*/

            // Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
            //соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2p.Определить значение угла для
            // минутной стрелки, а также количество полных часов и полных минут
            /* Console.WriteLine("Задача 27");
             Random rnd = new Random();
             double y = rnd.Next(0, 360);
             double b = 4 * y;
             Console.WriteLine($"Градусы: {y}");
             Console.WriteLine($"Время {b} минут ");
             Console.ReadKey();*/

            //Создать программу, которая будет выводить на экран меньшее по модулю из трёх
            //введённых пользователем вещественных чисел
            /*Console.WriteLine("Задача 28");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c);
            {
                Console.WriteLine($"Меньшее число {a} ");
                Console.ReadKey();
            }

            if (b < c && b < a);
            {
                Console.WriteLine($"Меньшее число {b} ");
                Console.ReadKey();
            }

            if (c < b && c < a) ;
            {
                Console.WriteLine($"Меньшее число {c} ");
                Console.ReadKey();
            }
            Console.WriteLine("Конец");
            Console.ReadKey();*/

            //Найти сумму большего и меньшего из трёх заданных чисел
            /* Console.WriteLine("Задача 29");
             Console.Write("a = ");
             int a = int.Parse(Console.ReadLine());
             Console.Write("b = ");
             int b = int.Parse(Console.ReadLine());
             Console.Write("c = ");
             int c = int.Parse(Console.ReadLine());

             if (a < b & a < c & b < c);
             {
                 Console.WriteLine($"Сумма меньшего и большего чисел: {a + c} ");
                 Console.ReadKey();
             }

             if (a < b & a < c & c < b);
             {
                 Console.WriteLine($"Сумма меньшего и большего чисел: {a + b} ");
                 Console.ReadKey();
             }
             if (b < c & b < a & c < a);
             {
                 Console.WriteLine($"Сумма меньшего и большего чисел: {b + a} ");
                 Console.ReadKey();
             }
             if (b < c & b < a & a < c) ;
             {
                 Console.WriteLine($"Сумма меньшего и большего чисел: {b + c} ");
                 Console.ReadKey();
             }
             if (c < b & c < a & a < b) ;
             {
                 Console.WriteLine($"Сумма меньшего и большего чисел: {c + b} ");
                 Console.ReadKey();
             }
             if (c < b & c < a & b < a) ;
             {
                 Console.WriteLine($"Сумма меньшего и большего чисел: {c + a} ");
                 Console.ReadKey();
             }
             Console.WriteLine("Конец");
             Console.ReadKey();*/

            //Подсчитать общее количество делителей натурального числа
            /*Console.WriteLine("Задача 30");
            Console.Write("Число: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Делители: ");
            for (var c = 2; c <= n / 2; ++c) if (n % c == 0) Console.Write(" {0}", c);
            Console.WriteLine();
            Console.ReadKey();*/

            //Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
            //вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
            //уравнений вида A* X3 +B * X2 + C * X + D = 0.На факультативе по математике Васе
            //задали решить около ста уравнений как раз такого вида.Но, к сожалению, Вася
            //забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все корни уравнений
            //– целые числа и находятся на отрезке[-100, 100]. Поэтому у Васи
            //есть шанс найти их методом перебора, но для этого ему придется затратить уйму
            //времени, т.к.возможно необходимо будет осуществить перебор нескольких тысяч
            //значений.Помогите Васе написать программу, которая поможет ему найти корни кубических уравнений!
            /*Console.WriteLine("Задача 31");*/
            //не выполнено

            // Заданы первый и второй элементы арифметической прогрессии.
            // Требуется написать программу, которая вычислит элемент прогрессии по ее номеру.
            /*Console.WriteLine("Задача 32");
            double i, y;
            double Sn;
            y = Convert.ToInt16(Console.ReadLine());
            Sn = 0;
            for (i = 1; i <= y; i++)
            {
                Sn += i;
                Console.WriteLine(Sn);
            }
            Sn = Sn * (y / 2);
            Console.WriteLine(Sn);
            Console.ReadLine();*/

            //Если я пенсионер или студент и не трудоустроен, то не получаю кредит,
            //а если трудоустроен, получаю кредит. Ну а если я и пенсионер, и студент,
            //(трудоустройство тут не имеет значения),то не должен получить.
            //Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
            //или кто-то ещё.Вывести информацию: дадут кредит или нет.
            /*Console.WriteLine("Задача 33");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Если вы студент или пенсионер и трудоустроены => нажмите 1 ");
            Console.WriteLine("Если вы студент или пенсионер и не трудоустроены => нажмите 2 ");
            Console.WriteLine("Если вы студент-пенсионер (не имеет значения трудоустроены вы или нет) => нажмите 3 ");
            Console.WriteLine("Если вы не являетесь студентом и/или пенсионером => нажмите 4 ");
            Console.Write(" ");
            int a = int.Parse(Console.ReadLine());

            var line = Console.ReadLine();
            int choice2;

            if (a == 1) ;
            {
                
                Console.WriteLine("Вам могут одобрить кредит ");
            }
            
            if (a == 2) ;
            {
                
                Console.WriteLine("Вам не могут одобрить кредит ");
            }
            if (a == 3) ;
            {
                
                Console.WriteLine("Вам не могут одобрить кредит ");
            }
            if (a == 4) ;
            {
                
                Console.WriteLine("Вам могут одобрить кредит ");
            }
            Console.WriteLine("");
            Console.ReadKey();*/

            //Составить программу, которая:
            //а) запрашивает имя человека и повторяет его на экране;
            //б) запрашивает имя человека и повторяет его на экране с приветствием.
            /*Console.WriteLine("Задача 33а");
            Console.WriteLine(" ");
            Console.Write("Введите свое имя: ");
            string S1name = Console.ReadLine();
            Console.WriteLine(S1name);
            Console.ReadKey();*/

            /*Console.WriteLine("Задача 33б");
            Console.WriteLine(" ");
            Console.Write("Введите свое имя: ");
            string S1name = Console.ReadLine();
            Console.WriteLine("Добрый день, " + S1name);
            Console.ReadKey();*/

            /* Console.WriteLine("Задача 35");
             Console.WriteLine(" ");
             Console.Write("    ");
             string message1 = Console.ReadLine();
             Console.WriteLine("Как тебя зовут?");
             Console.Write("    ");
             string S1name = Console.ReadLine();
             Console.WriteLine("Привет, " + S1name + ". Меня зовут Том Реддл");
             Console.Write("    ");
             string message2 = Console.ReadLine();
             Console.WriteLine("Да");
             Console.Write("    ");
             string message3 = Console.ReadLine();   
             Console.WriteLine("Нет");
             System.Threading.Thread.Sleep(5000);
             Console.ForegroundColor = ConsoleColor.DarkRed;
             Console.WriteLine("Но могу показать");
             Console.ResetColor();
             Console.WriteLine("");
             Console.ReadKey();*/

            //Вычислить контрольную цифру штрихкода(EAN13).
            //a. 12 цифр определяются случайным образом.
            //b. 12 цифр вводит пользователь
            /* Console.WriteLine("Задача 36");
             //Алгоритм поиска этого значения таков:
             //1) Оставляем 12 цифр(последняя 13 — контрольная которую ищем).
             //2) Суммируем разряды, стоящие на четных местах.
             //3) Результат пункта 2 умножаем на 3.
             //4) Суммируем разряды, стоящие на нечетных местах.
             //5) Суммируем результаты пунктов 3 и 4.
             //6) В полученном числе крайнюю справа цифру(остаток от деления на 10) вычесть из 10, если остаток 0 то значение равно 0.
             Random rnd = new Random();
             int a = rnd.Next(0, 9);
             int b = rnd.Next(0, 9);
             int c = rnd.Next(0, 9);
             int d = rnd.Next(0, 9);
             int e = rnd.Next(0, 9);
             int f = rnd.Next(0, 9);
             int g = rnd.Next(0, 9);
             int h = rnd.Next(0, 9);
             int i = rnd.Next(0, 9);
             int j = rnd.Next(0, 9);
             int k = rnd.Next(0, 9);
             int l = rnd.Next(0, 9);
             Console.WriteLine($"Сгенерировалось число {a}{b}{c}{d}{e}{f}{g}{h}{i}{j}{k}{l}");
             int x1 = b + d + f + h + j + l;
             int x = x1 * 3;
             int y = a + c + e + g + i + k;
             int z1 = x + y;
             double z2 = z1;

             Console.WriteLine($"Последняя цифра в числе {z2} - контрольная цифра штрихкода(EAN13)");
             Console.ReadKey();*/

           /* Console.WriteLine("Задача 36");
            Console.WriteLine("Введите 12 раз цифры от 0 до 9");
            Console.Write(" ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int c = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int d = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int e = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int f = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int g = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int h = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int i = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int j = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int k = int.Parse(Console.ReadLine());
            Console.Write(" ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a}{b}{c}{d}{e}{f}{g}{h}{i}{j}{k}{l}");
            int x1 = b + d + f + h + j + l;
            int x = x1 * 3;
            int y = a + c + e + g + i + k;
            int z1 = x + y;
            double z2 = z1;

            Console.WriteLine($"Последняя цифра в числе  {z2} - контрольная цифра штрихкода(EAN13)");
            Console.ReadKey();*/

        }
    }
}




