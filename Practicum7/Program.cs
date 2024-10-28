using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. вывести в столбик 10 раз слово "Привет";

            //Способ while
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Привет");
            //    i++;
            //}
            //int i = 0;

            //Способ do while
            //do
            //{
            //    Console.WriteLine("Привет");
            //    i++;
            //} while (i < 10);

            //Способ for
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Привет");
            //}


            //Задание 2. вывести в столбик первые 10 натуральных чисел;

            //Способ while
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int i = 1;

            //Способ do while
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            //Способ for
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //Задание 3.вывести в столбик первые 5 натуральных чисел в обратном порядке;

            //Способ while
            //int i = 5;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //Способ do while
            //int i = 5;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //} while (i >= 1);

            //Способ for
            //for (int i = 5; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Задание 4.вывести на экран целые числа из интервала от 1 до n;

            //Способ while
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());

            //int i = 1;
            //while (i <= n)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Способ do while
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= n);

            //Способ for
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //Задание 5.запросить у пользователя 5 слов, после чего вывести вначале дважды каждое нечетное слово
            //и затем трижды каждое четное слово, между выводимыми словами вставить разделитель
            //в виде трех символьных пробелов(“   ”).
            //string[] words = new string[5];
            //Console.WriteLine("Введите 5 слов:");
            //for (int i = 0; i <5; i++)
            //{
            //    words[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Результат:");
            //for (int i = 0; i <5; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(words[i] + "   " + words[i] + "   ");
            //    }
            //    else
            //    {
            //        Console.Write(words[i] + "   " + words[i] + "   " + words[i] + "   ");
            //    }
            //}
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
