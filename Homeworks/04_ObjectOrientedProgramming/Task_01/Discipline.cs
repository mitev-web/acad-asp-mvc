using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    class Discipline
    {
        private string name;
        public string Name
        {
          get { return name; }
          set { name = value; }
        }

        private Teacher teacher;

        internal Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        private byte numberLectures;

        public byte NumberLectures
        {
            get { return numberLectures; }
            set { numberLectures = value; }
        }

        private byte numberExcercises;

        public byte NumberExcercises
        {
            get { return numberExcercises; }
            set { numberExcercises = value; }
        }

    
    }
}
