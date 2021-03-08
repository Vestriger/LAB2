//•	Дана строка из 256 английских букв. Записать через пробел 30 символов этой строки,
//стоящих на случайных местах. Желательно сделать только одно обращение к классу Random.
using System;
using System.Text;

namespace lab_2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder longString = new StringBuilder("abcdefghijklmnop"); // 16 english letters
            while (longString.Length != 256) longString.Append(longString); // 16 iterations to become 256 letters 
            Random random = new Random();
            for (int i = 0; i < 30; i++) Console.Write(longString[random.Next(256)] + " ");
        }
    }
}