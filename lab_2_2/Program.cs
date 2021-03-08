//Дана строка. Найти в ней все заглавные буквы, не входящие в английский алфавит.

using System;
using System.Text.RegularExpressions;

namespace lab_2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"[А-Я]{1}");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.Write(match.Value + " ");
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
    }
}