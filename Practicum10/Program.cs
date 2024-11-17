using System;
using System.Collections.Generic;
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
            //int[] omas = { 3, 16, 35, 1, 22, 3, 4, 11 };
            //Array.Clear(omas, 1, 2);
            //Array.Clear(omas, 1, 3);
            //foreach(int el in omas)
            //{
            //    Console.WriteLine(el);
            //}


            //Task 2
            //int[] omas = { 3, 16, 35, 1, 22 };
            //Array.Resize(ref omas, 7);
            //foreach(int el in omas)
            //{
            //    Console.WriteLine(el);
            //}


            //Task 3
            int[] omas = new int[10];
            Random rnd = new Random();
            for( int i = 0;  i < omas.Length; i++)
            {
                omas[i] = rnd.Next(-5, 6);
            }
            foreach(var el in omas)
            {
                Console.Write($"{el}, ");
            }
            int index = -1;
            for ( int i = 0;i < omas.Length;i++)
            {
                if (omas[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            if(index != -1)
            {
                Console.WriteLine($"\nИндекс первого отрицательного элемента: {index}");
            }
            else
            {
                Console.WriteLine("\nОтрицательных элементов в массиве нет");
            }

            Console.Read();
        }
    }
}
