
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Mouths // Перечисление для месяцев года
        {
            //Январь = 0, Февраль = 1, Март = 2, Апрель = 3, Май = 4, Июнь = 5, Июлю = 6, Август = 7, Сентябрь = 8, Октябрь = 9, Ноябрь = 10, Декабрь = 11,
            Январь , Февраль , Март , Апрель , Май , Июнь , Июлю , Август , Сентябрь , Октябрь , Ноябрь , Декабрь 
        }
        static void Main(string[] args)
        {
            
            Mouths i;
            for (i = Mouths.Январь; i <= Mouths.Декабрь; i++)
                Console.WriteLine((int)i + "     " + i);
            Console.Read();
        }
    }
}