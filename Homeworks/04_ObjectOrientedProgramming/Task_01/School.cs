using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    class School
    {
        private List<Class> classes;

        internal List<Class> Classes
        {
            get { return classes; }
            set { classes = value; }
        }
    }
}
