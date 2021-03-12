// С помощью класса DateTime вывести на консоль названия месяцев на французском языке.
// По желанию обобщить на случай, когда язык задается с клавиатуры.

using System;
using System.Globalization;

namespace lab_2_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your language : ");
            Console.WriteLine("For Russian enter: ru");
            Console.WriteLine("For French enter: fr");
            Console.WriteLine("For German enter: ger");
            Console.WriteLine("For English enter: en");
            Console.WriteLine("For Spanish enter: sp");
            string lan = Console.ReadLine();
            DateTime date = new DateTime(2020, 1, 1);
            switch (lan)
            {
                case "ru":
                    var usCulture = new CultureInfo("ru-RU");
                    for (int i = 0; i < 12; i++)
                    {
                        Console.Write(date.ToString("MMMM", usCulture.DateTimeFormat) + " ");
                        date = date.AddMonths(1);
                    }

                    break;
                case "fr":
                    var frCulture = new CultureInfo("fr-FR");
                    for (int i = 0; i < 12; i++)
                    {
                        Console.Write(date.ToString("MMMM", frCulture.DateTimeFormat) + " ");
                        date = date.AddMonths(1);
                    }

                    break;
                case "ger":
                    var gerCulture = new CultureInfo("de-DE");
                    for (int i = 0; i < 12; i++)
                    {
                        Console.Write(date.ToString("MMMM", gerCulture.DateTimeFormat) + " ");
                        date = date.AddMonths(1);
                    }

                    break;
                case "en":
                    var enCulture = new CultureInfo("en-US");
                    for (int i = 0; i < 12; i++)
                    {
                        Console.Write(date.ToString("MMMM", enCulture.DateTimeFormat) + " ");
                        date = date.AddMonths(1);
                    }

                    break;
                case "sp":
                    var spCulture = new CultureInfo("es-ES");
                    for (int i = 0; i < 12; i++)
                    {
                        Console.Write(date.ToString("MMMM", spCulture.DateTimeFormat) + " ");
                        date = date.AddMonths(1);
                    }

                    break;
                default:
                    Console.WriteLine("Wrong language");
                    break;
            }
        }
    }
}