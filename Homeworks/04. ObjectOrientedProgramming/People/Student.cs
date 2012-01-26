using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_02
{
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }


        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public Student()
        {

        }
    }
}
