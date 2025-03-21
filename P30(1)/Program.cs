using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<Person> people = new List<Person>();
                people.Add(new Russian("Алексей"));
                people.Add(new American("Алексей"));
                people.Add(new Ukraine("Алексей"));
                foreach (Person person in people)
                {
                    person.SayHello();
                }
            }
        }
    }
}

