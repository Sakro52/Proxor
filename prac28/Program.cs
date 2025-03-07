using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan", "Ivanov", 30);
            person.Output();
            Empolee epol = new Empolee("Ivan", "Ivanov", 25, "Tech Corp", "Developer");
            epol.Output();
            Student fafa = new Student("Ivan", "Ivanov", 19, 3);
            fafa.Output();
            Console.ReadLine();
        }
    }
}
