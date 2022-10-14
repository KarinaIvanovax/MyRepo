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
        static int CountLetters(char[] array, char[] arr)
        {
            int Count = 0;

            foreach (char ch in array)
                foreach (char cha in arr)
                    if (ch == cha)
                        Count++;
            return Count;
        }

        static int[,] Matrix(int[,] arr1, int[,] arr2)
        {
            if (arr1.GetLength(1) != arr2.GetLength(1))
            { 
                throw new Exception("Ошибка!");
            }
            int[,] array = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        array[i, j] += arr1[i, k] * arr2[i, k];
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 6.1");
            //Написать программу, которая вычисляет число гласных и согласных букв в файле.
            char[] glasnye = "аеиоуыэюя".ToUpper().ToCharArray();
            char[] sogl = "бвгджзйклмнпрстфхцчшщъь".ToUpper().ToCharArray();
            Console.Write("Введите предложение: ");
            string message = Console.ReadLine();
            char[] array = message.ToUpper().ToCharArray();
            int glasnyeCount = CountLetters(array, glasnye);
            int soglCount = CountLetters(array, sogl);
            Console.WriteLine($"Количество гласных: {glasnyeCount}");
            Console.WriteLine($"Количество согласных: {soglCount}");
            Console.ReadKey();

            Console.WriteLine("Упражнение 6.2");
            //Написать программу, реализующую умножению двух матриц, заданных в виде двумерного массива.
            //В программе предусмотреть два метода: метод печати матрицы,
            //метод умножения матриц(на вход две матрицы, возвращаемое значение – матрица).
            Random random = new Random();
            Console.WriteLine("Введите размер первой матрицы: ");
            Console.Write("i = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("j = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] myArr1 = new int[a, b];
            for (int i = 0; i < myArr1.GetLength(0); i++)
            {
                for (int j = 0; j < myArr1.GetLength(1); j++)
                {
                    myArr1[i, j] = random.Next(0, 9);
                    Console.Write(myArr1[i, j]);
                }
            }
            Console.WriteLine("\nВведите размер второй матрицы: ");
            Console.Write("i = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("j = ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] myArr2 = new int[c, d];
            for (int i = 0; i < myArr2.GetLength(0); i++)
            {
                for (int j = 0; j < myArr2.GetLength(1); j++)
                {
                    myArr2[i, j] = random.Next(0, 9);
                    Console.Write(myArr2[i, j]);
                }
            }
            int[,] array = Matrix(myArr1, myArr2);
            Console.Write(array);
            Console.ReadKey();

            Console.WriteLine("Упражнение 6.3");
            //Написать программу, вычисляющую среднюю температуру за год.
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

            int[][] temp = new int[12][];
            temp[0] = new int[30];
            temp[1] = new int[30];
            temp[2] = new int[30];
            temp[3] = new int[30];
            temp[4] = new int[30];
            temp[5] = new int[30];
            temp[6] = new int[30];
            temp[7] = new int[30];
            temp[8] = new int[30];
            temp[9] = new int[30];
            temp[10] = new int[30];
            temp[11] = new int[30];
            int summ1 = 0;
            double middle1 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[0][i] = random.Next(-20, 0);
                summ1 += temp[0][i];
                middle1 = summ1 / 30;
            }
            int summ2 = 0;
            double middle2 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[1][i] = random.Next(-20, 0);
                summ2 += temp[0][i];
                middle2 = summ2 / 30;
            }
            int summ3 = 0;
            double middle3 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[2][i] = random.Next(-20, 10);
                summ3 += temp[0][i];
                middle3 = summ3 / 30;
            }
            int summ4 = 0;
            double middle4 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[3][i] = random.Next(-10, 20);
                summ4 += temp[0][i];
                middle4 = summ4 / 30;
            }
            int summ5 = 0;
            double middle5 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[4][i] = random.Next(5, 25);
                summ5 += temp[0][i];
                middle5 = summ5 / 30;
            }
            int summ6 = 0;
            double middle6 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[5][i] = random.Next(10, 35);
                summ6 += temp[0][i];
                middle6 = summ6 / 30;
            }
            int summ7 = 0;
            double middle7 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[6][i] = random.Next(10, 35);
                summ7 += temp[0][i];
                middle7 = summ7 / 30;
            }
            int summ8 = 0;
            double middle8 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[7][i] = random.Next(10, 35);
                summ8 += temp[0][i];
                middle8 = summ8 / 30;
            }
            int summ9 = 0;
            double middle9 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[8][i] = random.Next(-10, 20);
                summ9 += temp[0][i];
                middle9 = summ9 / 30;
            }
            int summ10 = 0;
            double middle10 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[9][i] = random.Next(-20, 10);
                summ10 += temp[0][i];
                middle10 = summ10 / 30;
            }
            int summ11 = 0;
            double middle11 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[10][i] = random.Next(-20, 5);
                summ11 += temp[0][i];
                middle11 = summ11 / 30;
            }
            int summ12 = 0;
            double middle12 = 0;
            for (int i = 0; i < 30; i++)
            {
                temp[11][i] = random.Next(-20, 0);
                summ12 += temp[0][i];
                middle12 = summ12 / 30;
            }
            double[] averageTemp = new double[12] { middle1, middle2, middle3, middle4, middle5, middle6, middle7, middle8, middle9, middle10, middle11, middle12 };
            Console.WriteLine("Средняя температура в каждом месяце: ");
            for (int i = 0; i < averageTemp.Length; i++)
            {
                Console.WriteLine(averageTemp[i]);
            }
            Console.ReadKey();


        }
    }
}
