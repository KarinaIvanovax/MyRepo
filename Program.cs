using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_6
{
    internal class Program
    {
        //static int CountLetters(char[] array, char[] arr)
        //{
        //    int Count = 0;

        //    foreach (char ch in array)
        //        foreach (char cha in arr)
        //            if (ch == cha)
        //                Count++;
        //    return Count;
        //}
        double[] ArrayAverage(params double[][] temp)
        {
            return Enumerable.Range(0, temp[0].Length)
                       .Select(i => temp.Select(a => a.Skip(i).First()).Average())
                       .ToArray();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Упражнение 6.1");
            ////Написать программу, которая вычисляет число гласных и согласных букв в файле.
            //char[] glasnye = "аеиоуыэюя".ToUpper().ToCharArray(); 
            //char[] sogl = "бвгджзйклмнпрстфхцчшщъь".ToUpper().ToCharArray();
            //Console.Write("Введите предложение: ");
            //string message = Console.ReadLine(); 
            //char[] array = message.ToUpper().ToCharArray(); 
            //int glasnyeCount = CountLetters(array, glasnye); 
            //int soglCount = CountLetters(array, sogl); 
            //Console.WriteLine($"Количество гласных: {glasnyeCount}");
            //Console.WriteLine($"Количество согласных: {soglCount}");
            //Console.ReadKey();

            //Console.WriteLine("Упражнение 6.2");
            ////Написать программу, реализующую умножению двух матриц, заданных в виде двумерного массива.
            ////В программе предусмотреть два метода: метод печати матрицы,
            ////метод умножения матриц(на вход две матрицы, возвращаемое значение – матрица).
            //int[,] myArr1 = new int[3, 3];
            //int[,] myArr2 = new int[3, 3];

            Console.WriteLine("Упражнение 6.2");
            //Написать программу, вычисляющую среднюю температуру за год.
            //Создать двумерный рандомный массив temperature[12, 30],
            //в котором будет храниться температура для каждого дня месяца
            //(предполагается, что в каждом месяце 30 дней).
            //Сгенерировать значения температур случайным образом.
            //Для каждого месяца распечатать среднюю температуру.
            //Для этого написать метод, который по массиву temperature[12, 30] для каждого месяца
            //вычисляет среднюю температуру в нем, и в качестве результата возвращает
            //массив средних температур.Полученный массив средних температур отсортировать по возрастанию.
            int[,] temperature = new int[12, 30];
            Random random = new Random();
            int sum = 0;
            float middleT = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = random.Next(-20, 35);
                    //Console.Write("{0}\t", temperature[i, j]);
                    sum += temperature[i, j];
                    middleT = sum / (12 * 30);
                }
            }
            Console.WriteLine($"Средняя температура за год: {middleT}");

            double[][] temp = new double[12][];
            temp[0] = new double[30];
            temp[1] = new double[30];
            temp[2] = new double[30];
            temp[3] = new double[30];
            temp[4] = new double[30];
            temp[5] = new double[30];
            temp[6] = new double[30];
            temp[7] = new double[30];
            temp[8] = new double[30];
            temp[9] = new double[30];
            temp[10] = new double[30];
            temp[11] = new double[30];
            //int summ = 0;
            //double middle = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[0][i] = random.Next(-20, 0);
                Console.WriteLine(temp[i] + " ");
                //summ += temp[0][i];
                //middle = sum / 30;
            }
            for(int i = 0; i < 30; i++)
            {
                temp[1][i] = random.Next(-20, 0);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[2][i] = random.Next(-20, 10);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[3][i] = random.Next(-10, 20);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[4][i] = random.Next(5, 25);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[5][i] = random.Next(10, 35);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[6][i] = random.Next(10, 35);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[7][i] = random.Next(10, 35);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[8][i] = random.Next(-10, 20);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[9][i] = random.Next(-20, 10);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[10][i] = random.Next(-20, 5);
                Console.WriteLine(temp[i] + " ");
            }
            for (int i = 0; i < 30; i++)
            {
                temp[11][i] = random.Next(-20, 0);
                Console.WriteLine(temp[i] + " ");
            }
            var averages = ArrayAverage(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9], temp[10], temp[11]);
            //Console.WriteLine($"Средняя температура: {middle}");
        }
    }
}
