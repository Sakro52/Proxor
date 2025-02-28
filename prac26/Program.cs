using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac26
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Person person1 = new Person(50, 65);
                Console.WriteLine(person1.CheckAge());   

                
                person1.RetirementAge = 60;
                Console.WriteLine(person1.CheckAge()); 

               
                Person person2 = new Person(65, 65);
                Console.WriteLine(Person.CheckRetirementStatus(person2)); 
            Console.ReadKey();
            }
        }
    }

