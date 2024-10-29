using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. вывести в столбик 10 раз слово "Привет"
            //Способ while

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Привет");
            //    i++;
            //}

            //Способ do while

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Привет");
            //    i++;
            //}
            //while (i < 10);

            //Способ for

            //for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Привет");
            //    }

            //Задание 2.вывести в столбик первые 10 натуральных чисел;
            //Способ while

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Способ do while

            //int i = 1;
            //do

            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 10);

            //Способ for

            //for(int i=1;i<=10;i++)
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
            //    {
            //        Console.WriteLine(i);
            //    }

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
            //for (int i = 0; i <words.Length; i++)
            //{
            //    words[i] =(Console.ReadLine());
            //}
            //Console.WriteLine("Результат:");
            //for (int i = 0; i <words.Length; i++)
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





            //Задача 1. Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.

            //int[] omas = new int[8];
            //Console.WriteLine("Заполнение одномерного массива");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"omas[{i}]=");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}

            //Задача 2.Составьте программу ввода(без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.

            //int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            //Console.WriteLine("Вывод");
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}

            //Задача 3.Массив предназначен для хранения значений ростов двенадцати человек.С помощью датчика случайных чисел заполнить массив целыми значениями,
            //лежащими в диапазоне от 163 до 190 включительно.

            //int[] omas = new int[12];
            //Random ram = new Random();

            //for (int i = 0; i <omas.Length; i++)
            //{
            //    omas[i] = ram.Next(163,190);

            //}
            //Console.WriteLine("Вывод");
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}

            //int[] omas = new int[31];
            //Random ram = new Random();

            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = ram.Next(5, 25);

            //}
            //Console.WriteLine("Вывод");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            //int sum = 0;
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    sum = sum + omas[i];
            //}
            //Console.WriteLine($"Средния температура ={sum/omas.Length}");
            Console.ReadLine();
            }
        }
    }
