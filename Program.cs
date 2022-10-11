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

            Console.WriteLine("Задача 2");
            //Месяц - Октябрь. Климат благоприятный. Пиво свежее. И холодно. Два клана воюют.
            //Сидя по разные стороны длинного стола викингов, Bavarian Beer Bears и Scandinavian Schöllers
            //готовятся сразиться друг с другом в историческом испытании.Игра пятерок викингов!
            //Викинги дружелюбный народ, жадный до пива.Цель игры состоит в том,
            //чтобы обе команды набрали одинаковое количество пятерок, чтобы вся орда викингов
            //получила бесплатную порцию пива от рефери Бьорга Бьоргесона.
            //Однако Бьорг пил весь день и поэтому потерял способность сравнивать количество пятерок,
            //которое показывают викинги. Создайте функцию, которая принимает массивы двух команд,
            //сравнивает количество показанных пятерок и, если они совпадают, возвращает
            //«Drinks All Round! Free Beers on Bjorg!».Если они этого не сделают, ответьте:
            //«Ой, Бьорг - пончик! Ни для кого пива!».
            //Гарантируется, что оба массива будут содержать только целые числа от 0 до 9.


            Console.WriteLine("Задача 3");
            //3. История в жэке. Начался отопительный сезон, в городе начали включать отопление
            //и у жителей возникают проблемы. Для решения этих проблем они идут в жэк. В жэке есть 3 окна:
            //первое окно помогает людям решить проблемы с отоплением(подключение и тд),
            //второе окно решает проблемы с оплатой отопления, в третье окно идут все остальные.
            //Необходимо создать структуру жителя. У жителя есть имя, номер паспорта(для однозначной идентификации),
            //проблема, темперамент.Проблема характеризуется номером и описанием.
            //Темперамент характеризуется степенью скандальности от 0 до  10
            //(10 - скандалист, 0 - паинька), умом(1 - умный, 0 - тупой).
            //В каждое окно жители встают по очереди.Перед входом в жэк стоит Зина, которая уточняет у жителей,
            //какая у них проблема и по ключевым словам определяет их в нужное окно.
            //Если житель скандалист(от 5 и выше), то он не будет обращать внимание на очередь и обгонит людей,
            //которые впереди него(на сколько человек обгонять житель спрашивает у пользователя).
            //Если человек тупой, то он встаёт не в то окно, даже несмотря на указание Зины(случайным образом).
            //К Зине все выстраиваются в стек.

        }
    }
}
