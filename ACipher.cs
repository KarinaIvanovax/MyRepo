using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class ACipher : ICipher
    {
        public string encode(string str)//зашифровываем
        {

            string bukvs = "";
            for (int i = 0; i < str.Length; i++)//проходимся по строке
            {
                bukvs = bukvs + (char)(str[i] + 1);//сдвигаем букву вперед

            }
            return bukvs;
        }
        public string decode(string str)
        {

            string bukvss = "";
            for (int i = 0; i < str.Length; i++)
            {
                bukvss = bukvss + (char)(str[i] - 1);//сдвигаем букву назад

            }
            return bukvss;
        }
    }
}
