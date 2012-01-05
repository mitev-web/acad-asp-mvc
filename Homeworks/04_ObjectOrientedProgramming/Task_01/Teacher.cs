using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    class Teacher : Human
    {
        private List<Discipline> disciplines;

        internal List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }
    }
}
