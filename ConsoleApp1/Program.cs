using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.Write("x=");
            //    int x = int.Parse(Console.ReadLine());
            //    int y = x < 0 ? x + 1 : x - 1;
            //    Console.Write($"y={y}");
            //    Console.Read();
            //}
            //catch 
            //{


            //}


            //try
            //{
            //    //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7.
            //    //По указанному номеру n вывести название соответствующего дня недели.
            //    Console.Write("Номер дня недли");
            //    int day = int.Parse(Console.ReadLine());
            //    switch (day)
            //    {
            //        case 1:Console.WriteLine("Понедельник");break;
            //        case 2: Console.WriteLine("Вторник"); break;
            //        case 3: Console.WriteLine("Среда"); break;
            //        case 4: Console.WriteLine("Четверг"); break;
            //        case 5: Console.WriteLine("Пятница"); break;
            //        case 6: Console.WriteLine("Суббота"); break;
            //        case 7: Console.WriteLine("Воскресенье"); break;
            //        default: Console.WriteLine("нет такого дня"); break;    
            //    }

            //}
            //catch
            //{

            //}
            //Console.ReadLine();


            //try
            //{
            //    //Задача 2 По номеру месяца вывести название времени года.
            //    Console.Write("Номер Месяца ");
            //    int month = int.Parse(Console.ReadLine());
            //    switch (month)
            //    {
            //        case 12: Console.WriteLine("Зима"); break;
            //        case 1: Console.WriteLine("Зима"); break;
            //        case 2: Console.WriteLine("Зима"); break;
            //        case 3: Console.WriteLine("Весна"); break;
            //        case 4: Console.WriteLine("Весна"); break;
            //        case 5: Console.WriteLine("Весна"); break;
            //        case 6: Console.WriteLine("Лето"); break;
            //        case 7: Console.WriteLine("Лето"); break;
            //        case 8: Console.WriteLine("Лето"); break;
            //        case 9: Console.WriteLine("Осень"); break;
            //        case 10: Console.WriteLine("Осень"); break;
            //        case 11: Console.WriteLine("Осень"); break;
            //        default: Console.WriteLine("Под таким номером нет времени года"); break;
            //    }

            //}
            //catch
            //{

            //}
            //Console.ReadLine();




            //try
            //{
            //    //Задача 3. Дан признак транспортного средства: a – автомобиль, в – велосипед,
            //    //м - мотоцикл, с – самолет, п – поезд.
            //    //Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
            //    Console.Write("Ввидите признак ");
            //    char Ven =char.Parse(Console.ReadLine());
            //    switch (Ven)
            //    {
            //        case 'а': Console.WriteLine("Автомобиль 250км.ч"); break;
            //        case 'в': Console.WriteLine("Велосипед 52км.ч"); break;
            //        case 'м': Console.WriteLine("Мотоцикл 200км.ч"); break;
            //        case 'с': Console.WriteLine("Сомолет 360км.ч"); break;
            //        case 'п': Console.WriteLine("Поезд 574км.ч"); break;

            //        default: Console.WriteLine("Под таким поризнаком нет транспорта"); break;
            //    }

            //}
            //catch
            //{

            //}
            //Console.ReadLine();





            try
            {
                //Задача 4. Вывести название предмета по введенной первой букве:
                //ф – физика, м – математика, и – история, г – география, б – биология.
                Console.Write("Ввидите Первую Букву Предмета ");
                char Ven = char.Parse(Console.ReadLine());
                switch (Ven)
                {
                    case 'ф': Console.WriteLine("физика"); break;
                    case 'м': Console.WriteLine("математика"); break;
                    case 'и': Console.WriteLine("история"); break;
                    case 'г': Console.WriteLine("география"); break;
                    case 'б': Console.WriteLine("биология"); break;

                    default: Console.WriteLine("Под такой буквой нет предмета"); break;
                }

            }
            catch
            {

            }
            Console.ReadLine();
        }
    }
}
