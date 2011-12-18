using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    class Student : Human
    {

        private string classNumber;

        public string ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        //student may have custom disciplines, that may be different than these in class
        private List<Discipline> disciplines;
       
        internal List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }
    }
}
