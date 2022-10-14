using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__ot_8._10._22_
{
    //struct student
    //{
    //    public string surname;
    //    public string name;
    //    public DateTime birthday;
    //    public string exam;
    //    public int score;
    //}
    //class ScoreComp: IComparer<string[]>
    //{
    //    public int Compare(string[] o1, string[] o2)
    //    {
    //        int a = Convert.ToInt32(o1[1]);
    //        int b = Convert.ToInt32(o2[1]);

    //        if (a > b)
    //        {
    //            return 1;
    //        }
    //        else if (a < b)
    //        {
    //            return -1;
    //        }

    //        return 0;
    //    }
    //}
    internal class Program
    {
        //public class citizens
        //{
        //    public string name;
        //    public int passport;
        //    public string problem;
        //    public int temp;
        //    public bool mind;

        //    public citizens(string name, int passport, string problem, int temp, bool mind)
        //    {
        //        this.name = name;
        //        this.passport = passport;
        //        this.problem = problem;
        //        this.temp = temp;
        //        this.mind = mind;
        //    }

        //}
        //public class Check
        //{
        //    public bool UserInutWithCheckInteger(out int userNumber)
        //    {
        //        Console.Write("Введите число: ");
        //        while (!int.TryParse(Console.ReadLine(), out userNumber))
        //        {
        //            Console.WriteLine("Ошибка, введите число: ");
        //        }
        //        return true;
        //    }
        //}
        //public class Window
        //{
        //    Check check = new Check();
        //    public string problem;
        //    public List<citizens> notSortedQueueCitizens = new List<citizens>();
        //    public Queue<citizens> queueCitizens;
        //    public void PrintAllCitizens()
        //    {
        //        for (int i = 0; i < notSortedQueueCitizens.Count; i++)
        //        {
        //            Console.WriteLine($"{i}: {notSortedQueueCitizens[i].name}");
        //        }
        //    }
        //    public void SortVillagers()
        //    {
        //        Console.WriteLine($"Окно: {problem}");
        //        PrintAllCitizens();
        //        for (int i = 0; i < notSortedQueueCitizens.Count; i++)
        //        {
        //            if (notSortedQueueCitizens[i].temp >= 5)
        //            {
        //                int userChoose;
        //                Console.Write($"{notSortedQueueCitizens[i].name} - скандалист.");
        //                check.UserInutWithCheckInteger(out userChoose);
        //                if (i - userChoose > 0)
        //                {
        //                    citizens rotate = notSortedQueueCitizens[i - userChoose];
        //                    notSortedQueueCitizens[i - userChoose] = notSortedQueueCitizens[i];
        //                    notSortedQueueCitizens[i] = rotate;
        //                }
        //            }
        //        }
        //        queueCitizens = new Queue<citizens>(notSortedQueueCitizens);
        //    }
        //    public void WorkWithVillager()
        //    {
        //        while (queueCitizens.Count > 0)
        //        {
        //            citizens citizen = queueCitizens.Dequeue();
        //            Console.WriteLine($"{citizen.passport}: {citizen.name}");
        //        }
        //    }
        //}
        //public class Zina
        //{
        //    Window[] allWindows;
        //    public Stack<citizens> stackCitizens = new Stack<citizens>();
        //    public void InsertAllStack()
        //    {
        //        stackCitizens.Push(new citizens("A", 0000, "Подключение", 10, true));
        //        stackCitizens.Push(new citizens("Б", 1111, "Другое", 2, false));
        //        stackCitizens.Push(new citizens("В", 2222, "Оплата", 3, true));
        //        stackCitizens.Push(new citizens("Г", 3333, "Оплата", 6, true));
        //        stackCitizens.Push(new citizens("Д", 4444, "Другое", 1, true));
        //        stackCitizens.Push(new citizens("Е", 5555, "Подключение", 9, true));
        //        stackCitizens.Push(new citizens("Ж", 6666, "Оплата", 4, false));
        //        stackCitizens.Push(new citizens("З", 7777, "Другое", 5, true));
        //        stackCitizens.Push(new citizens("И", 8888, "Подключение", 8, false));
        //        stackCitizens.Push(new citizens("Й", 9999, "Оплата", 7, true));

        //    }
        //    public Zina(Window[] allWindows)
        //    {
        //        this.allWindows = allWindows;
        //        InsertAllStack();
        //    }
        //    public void Distribution()
        //    {
        //        while (stackCitizens.Count > 0)
        //        {
        //            citizens citizen = stackCitizens.Pop();
        //            if (citizen.mind)
        //            {
        //                for (int i = 0; i < allWindows.Length; i++)
        //                {
        //                    if (citizen.problem == allWindows[i].problem)
        //                    {
        //                        allWindows[i].notSortedQueueCitizens.Add(citizen);
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Random random = new Random();
        //                int villageChoose = random.Next(0, allWindows.Length);
        //                allWindows[villageChoose].notSortedQueueCitizens.Add(citizen);
        //            }

        //        }
        //    }
        //}

        static void Graph()
        {
            Random rand = new Random();
            Queue<int> NomersVersh = new Queue<int>();
            Console.Write("Введите количество вершин: ");
            int CountVersh = int.Parse(Console.ReadLine()) - 1;
            if (CountVersh >= 3)
            {
                bool[] UsedVersh = new bool[CountVersh + 1];
                int[][] SmezhVersh = new int[CountVersh + 1][];

                for (int i = 0; i < CountVersh + 1; i++)
                {
                    SmezhVersh[i] = new int[CountVersh + 1];
                    Console.Write($"\n{i + 1} вершина - [");
                    for (int j = 0; j < CountVersh + 1; j++)
                    {
                        SmezhVersh[i][j] = rand.Next(0, 2);
                    }
                    SmezhVersh[i][i] = 0;
                    foreach (var item in SmezhVersh[i])
                    {
                        Console.Write($" {item}");
                    }
                    Console.Write("]\n");
                }
                UsedVersh[CountVersh] = true;
                NomersVersh.Enqueue(CountVersh);
                Console.WriteLine("Начинаем обход с {0} вершины", CountVersh + 1);
                while (NomersVersh.Count != 0)
                {
                    CountVersh = NomersVersh.Peek();
                    NomersVersh.Dequeue();
                    Console.WriteLine("Перешли к узлу {0}", CountVersh + 1);

                    for (int i = 0; i < SmezhVersh.Length; i++)
                    {
                        if (Convert.ToBoolean(SmezhVersh[CountVersh][i]))
                        {
                            int v = i;
                            if (!UsedVersh[v])
                            {
                                UsedVersh[v] = true;
                                NomersVersh.Enqueue(v);
                                Console.WriteLine("Добавили в очередь узел {0}", v + 1);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Количество вершин некорректно!");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Задача 1");
            ////Создать студента из вашей группы (фамилия, имя, год рождения, с каким экзаменом
            ////поступил, баллы). Создать словарь для студентов из вашей группы(10 человек).
            ////В консоли необходимо создать меню:
            ////1.если человек вводит слово: Новый студент, то необходимо ввести информацию
            ////о новом студенте и добавить его в лист
            ////2.Если человек вводит слово: Удалить, то по фамилии и имени удаляется студент
            ////3.Если человек вводит слово: Сортировать, то происходит сортировка по баллам(по возрастанию)
            //List<student> Students = new List<student>
            //{
            //   new student { surname = "Иванов", name = "Иван", birthday = new DateTime(2004, 08, 13), exam = "Информатика", score = 78},
            //   new student { surname = "А", name = "А", birthday = new DateTime(2005, 01, 01), exam = "Английский язык", score = 86},
            //   new student { surname = "Б", name = "Б", birthday = new DateTime(2004, 03, 04), exam = "Информатика", score = 54},
            //   new student { surname = "В", name = "В", birthday = new DateTime(2004, 12, 26), exam = "Информатика", score = 93},
            //   new student { surname = "Г", name = "Г", birthday = new DateTime(2004, 09, 01), exam = "Информатика", score = 72},
            //   new student { surname = "Д", name = "Д", birthday = new DateTime(2005, 04, 21), exam = "Физика", score = 88},
            //   new student { surname = "Е", name = "Е", birthday = new DateTime(2004, 02, 18), exam = "Английский язык", score = 95},
            //   new student { surname = "Ж", name = "Ж", birthday = new DateTime(2004, 07, 04), exam = "Информатика", score = 66},
            //   new student { surname = "З", name = "З", birthday = new DateTime(2004, 10, 31), exam = "Физика", score = 70},
            //   new student { surname = "К", name = "К", birthday = new DateTime(2004, 11, 25), exam = "Английский язык", score = 82},
            //};
            //Console.WriteLine("1. Добавить студента: введите 'Новый студент' ");
            //Console.WriteLine("2. Удалить студента: введите 'Удалить' ");
            //Console.WriteLine("3. Сортировка студентов: введите 'Сортировать' ");
            //string message = Console.ReadLine();
            //if (message == "Новый студент")
            //{
            //    Console.Write("Фамилия студента: ");
            //    string surname = Console.ReadLine();
            //    Console.Write("Имя студента: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Дата рождения: ");
            //    DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            //    Console.Write("Профильный экзамен: ");
            //    string exam = Console.ReadLine();
            //    Console.Write("Баллы за экзамен: ");
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    Students.Insert(1, new student {surname = surname, name = name, birthday = birthday, exam = exam, score = score });
            //    Students.ForEach(p => Console.WriteLine($"{p.surname} {p.name}, дата рождения: {p.birthday}, экзамен: {p.exam}, балл за экзамен: {p.score}"));
            //}
            //else if (message == "Удалить")
            //{
            //    Console.Write("Фамилия студента: ");
            //    string surname1 = Console.ReadLine();
            //    Console.Write("Имя студента: ");
            //    string name1 = Console.ReadLine();
            //    Students.Remove(new student() { surname = surname1, name = name1 });
            //    Console.WriteLine();
            //    Students.ForEach(s => Console.WriteLine($"{s.surname} {s.name}, дата рождения: {s.birthday}, экзамен: {s.exam}, балл за экзамен: {s.score}"));
            //}
            //else if (message == "Сортировать")
            //{
            //    //ScoreComp sc = new ScoreComp();
            //    Students.Sort();
            //    Students.ForEach(s => Console.WriteLine($"{s.surname} {s.name}, дата рождения: {s.birthday}, экзамен: {s.exam}, балл за экзамен: {s.score}"));
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Задача 2");
            ////Месяц - Октябрь. Климат благоприятный. Пиво свежее. И холодно. Два клана воюют.
            ////Сидя по разные стороны длинного стола викингов, Bavarian Beer Bears и Scandinavian Schöllers
            ////готовятся сразиться друг с другом в историческом испытании.Игра пятерок викингов!
            ////Викинги дружелюбный народ, жадный до пива.Цель игры состоит в том,
            ////чтобы обе команды набрали одинаковое количество пятерок, чтобы вся орда викингов
            ////получила бесплатную порцию пива от рефери Бьорга Бьоргесона.
            ////Однако Бьорг пил весь день и поэтому потерял способность сравнивать количество пятерок,
            ////которое показывают викинги. Создайте функцию, которая принимает массивы двух команд,
            ////сравнивает количество показанных пятерок и, если они совпадают, возвращает
            ////«Drinks All Round! Free Beers on Bjorg!».Если они этого не сделают, ответьте:
            ////«Ой, Бьорг - пончик! Ни для кого пива!».
            ////Гарантируется, что оба массива будут содержать только целые числа от 0 до 9.
            //Random random = new Random();
            //int[][] vikings = new int[2][];
            //vikings[0] = new int[5];
            //vikings[1] = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    vikings[0][i] = random.Next(0, 9);
            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    vikings[1][j] = random.Next(0, 9);
            //}
            //int count1 = 0;
            //int count2 = 0;
            //for (int i = 0; i < vikings[0].Length; i++)
            //{ 
            //        count1++;
            //}
            //for (int j = 0; j < vikings[1].Length; j++)
            //{
            //        count2++;  
            //}
            //if (count1 == count2)
            //{
            //    Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            //}
            //else
            //{
            //    Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            //}


            //Console.WriteLine("Задача 3");
            ////3.История в жэке.
            //string[] problems = { "Подключение", "Оплата", "Другое" };
            //Window[] allWindows = new Window[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    allWindows[i] = new Window();
            //    allWindows[i].problem = problems[i];
            //}
            //Zina zina = new Zina(allWindows);
            //for (int i = 0; i < allWindows.Length; i++)
            //{
            //    allWindows[i].SortVillagers();
            //    allWindows[i].WorkWithVillager();
            //}
            //Console.ReadKey();

            Console.WriteLine("Задача 4");
            //Написать метод для обхода графа в глубину или ширину - вывести на экран
            //кратчайший путь.
            Graph();
        }
    }
}
