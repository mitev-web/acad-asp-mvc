using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    class Class
    {
        private string classID;

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        private List<Student> students;

        internal List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        private List<Discipline> disciplines;

        internal List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        private List<Teacher> teachers;

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }




    }
}
