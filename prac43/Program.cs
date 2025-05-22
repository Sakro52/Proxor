using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            Console.WriteLine("До вызова методов:");
            Console.WriteLine($"{myClass.change}");
            Console.WriteLine($"{myStruct.change}");

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine("\nПосле вызова методов:");
            Console.WriteLine($"{myClass.change}");
            Console.WriteLine($"{myStruct.change}");
            Console.ReadKey();
        }
    }
}

