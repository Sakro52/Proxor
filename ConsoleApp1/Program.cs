using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // определите текущее количество элементов коллекции;
        static void El(int a)
        {
            Console.WriteLine(a);
         }
            // преобразуйте все буквы элементов в прописные;
            static void Caps(List<string> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el.ToUpper());
            }
            Console.WriteLine();
        }
        
        static void Output(List<string> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
        {

            List<string> list = new List<string>(){ "Бугати", "БМВ", "Мерседес", "Лотус", "Тоёта", "Лада" };
            // добавьте в список элементы строчными буквами; 
            // выведите содержимое коллекции на экран;
            list.Add("шевроле");
            Output(list);
            // определите текущее количество элементов коллекции;
            // выведите содержимое коллекции на экран;
            Caps(list);
            El(list.Count);
            // добавьте в коллекцию новый элемент в конец списка соответствующего варианта;
            list.Add("Ферари");
            Output(list);
            // добавьте в коллекцию новый элемент в начале списка соответствующего варианта;
            // выведите содержимое коллекции на экран;
            list.Insert(0,"Порш");
            Output(list);
            // удалите третий элемент коллекции; выведите содержимое коллекции на экран;
            list.RemoveAt(3);
            Output(list);
            // расположите элементы в обратном порядке
            list.Reverse();
            Output(list);
            Console.ReadKey();
        }
    }
}
