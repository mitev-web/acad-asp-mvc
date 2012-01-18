using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Task01
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public byte GroupNumber { get; set; }
        public List<int> Marks { get; set; }
        public Group Group { get; set; }
       
       //constructor with group

       //constructor w/o group

        public Student(string firstName, string lastName, string fN, string tel, string email, byte groupNumber, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        public Student(string firstName, string lastName, string fN, string tel, string email, byte groupNumber, List<int> marks, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
            this.Group = group;
        }
    }
}
