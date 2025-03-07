using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    internal class Student : Person
    {
        private int _yearOfStudy;

        public int YearOfStudy
        {
            get { return _yearOfStudy; }
            set { _yearOfStudy = value; }
        }


        public Student(string firstName, string surname, int age, int yearOfStudy)
            : base(firstName, surname, age)
        {
            YearOfStudy = yearOfStudy;
        }

        new public void Output()
        {
            Console.WriteLine($"{FirstName}\t{SurName}\t{Age}\t{YearOfStudy}");
        }
    }
}

