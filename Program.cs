using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //Task 1
            //int[] omas = new int[11];
            //Random rnd = new Random();
            //for(int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(0, 99);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Console.WriteLine("Одномерный массив кратный 11:");
            //foreach (int el in omas)
            //{
            //    if (el % 11 == 0) 
            //    {
            //        Console.WriteLine(el);
            //    }
            //}


            //Task 2
            //int[] omas = { 5, -4, 8, 7, 2 };
            //int count = 0, summ = 0;
            //foreach (var el in omas)
            //{
            //    if (el > 0)
            //    {
            //        summ += el;
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Сумма положительных циклов равна = {summ}\nКоличество положительных циклов равна = {count}");
            //Array.Clear(omas, 1, 2 );
            //foreach ( var el in omas)
            //{
            //    Console.WriteLine( el );
            //}


            //Task  3
            int[] omas = new int[6];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]=");
                omas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(omas);
            foreach(var el in omas)
            {
                Console.WriteLine(el);
            }


            Console.Read();
        }
    }
}
