using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> people = new List<string>(10);
            //Output(people);
            //List<string> strings = new List<string>() {"Маша", "Паша", "Саша"};
            //Output(strings);
            //var people2 = new List<string>() { "Cаша", "Маша", "Саша" };
            //Output(people2);
            //var employer = new List<string>(people2);
            //Output(employer);
            List<string> list = new List<string>(6);
            list.Add("Война и Мир");
            list.Add("Война и Мир");
            list.Add("Саша");
            list.Add("Война и Мир");
            list.Add("Война и Мир");
            list.Add("Война и Мир");
            Output(list);
            ToUp(list);
            Console.WriteLine(list.Count());
            list.Add("Колобок");
            Output(list);
            list.Insert(0, "Маша");
            Output(list);
            list.RemoveAt(2);
            Output(list);
            list.Reverse();
            Output(list);
            Console.ReadLine();
        }
        static void Output(List<string> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
        static void ToUp(List<string> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el.ToUpper());
            }
            Console.WriteLine();
        }
    }
}
