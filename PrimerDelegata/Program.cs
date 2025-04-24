using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDelegata
{
    internal class Program
    {
        //delegate void Message();//шаг1 объявление делегата
        //static void Main(string[] args)
        //{
        //    Message msg;//шаг2 Создание обьекта делегата
        //    Message msk;
        //    msg = Hello;//шаг3 Связка делегата с методом
        //    msg();//шаг4 Вызов делегата
        //    msk = Bye;
        //    msk();
        //    Console.Read();
        //}
        //static public void Hello() => Console.WriteLine("Hello, World!");//шаг5 Метод, который будет вызван делегатом
        //static public void Bye() => Console.WriteLine("Bye, World!");//шаг5 Метод, который будет вызван делегатом




        //    delegate void Message();//шаг1 объявление делегата
        //    static void Main(string[] args)
        //    {
        //        Message mgs;
        //        if(DateTime.Now.Hour < 12)
        //        {
        //            mgs = Hello;
        //        }
        //        else
        //        {
        //            mgs = Bye;
        //        }
        //        mgs();//шаг4 Вызов делегата
        //        Console.Read();
        //    }
        //    static void Hello() => Console.WriteLine("Доброе Утро");//шаг5 Метод, который будет вызван делегатом
        //    static void Bye() => Console.WriteLine("Добрый Вечер");//шаг5 Метод, который будет вызван делегатом



        ///Задача 1
        //delegate void Message(string name);//шаг1 объявление делегата
        //static void Main(string[] args)
        //{
        //    Message mgs;
        //    if (DateTime.Now.Hour < 12)
        //    {
        //        mgs = Hello;
        //    }
        //    else
        //    {
        //        mgs = Bye;
        //    }
        //    mgs("Василий");//шаг4 Вызов делегата
        //    Console.Read();
        //}
        //static void Hello(string name) => Console.WriteLine($"Доброе Утро, {name}");//шаг5 Метод, который будет вызван делегатом
        //static void Bye(string name) => Console.WriteLine($"Добрый Вечер, {name}");//шаг5 Метод, который будет вызван делегатом



        /// <summary>
        /// Задача 2
        /// </summary>
        /// <param name="args"></param>
        //    static void Main(string[] args)
        //        {
        //            Delegat.Operation operation;

        //            double a = 3, b = 4;

        //            operation = MathOperat.Add;
        //            operation(a, b);

        //            operation = MathOperat.Subtract;
        //            operation(a, b);

        //            operation = MathOperat.Multiply;
        //            operation(a, b);

        //            operation = MathOperat.Divide;
        //            operation(a, b);

        //            Console.Read();
        //        }
        //    }
        //}

        
        ///задача3 
        static void Main(string[] args)
        {
            AverageDelegate.AvgDelegate avgDelegate = AverageCalc.Average;
            int m = 7, n = 10;
            AverageDelegate.AvgDelegat avgDelegat = AverageCalc.Average;
            int o = 23, p = 32;
            double average = avgDelegate(m, n);
            double averag = avgDelegat(o, p);
            Console.WriteLine($"Среднее арифметическое от {m} до {n} равно {average}");
            Console.WriteLine($"Среднее арифметическое от {o} до {p} равно {averag}");
            Console.Read();
        }
    }
}



