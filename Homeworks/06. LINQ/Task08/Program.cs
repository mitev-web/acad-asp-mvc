using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task01;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property Group in the Student class. 
            //Extract all students from "Mathematics" department. Use the Join operator.
            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24027","+359342342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}),
            new Student("Ivan", "Petrov", "F33413","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,6,4,6}),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}),
            new Student("Marijka", "Umnoto","F636323","+359377342","mary_jane@mail.bg",2,new List<int> {4,2,6,5,5,4,5}),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}),
            };

            List<Group> groups = new List<Group>{
                new Group(1, "Mathematics"),
                new Group(2, "Art"),
            };


          // var mathStudents = students.Join(



            var mathStudents = from s in students
                               join g in groups
                               on s.GroupNumber equals g.GroupNumber
                               where g.DepartmentName == "Mathematics"
                               select new
                               {
                                   FirsName = s.FirstName,
                                   Group = g,
                               };

            foreach (var s in mathStudents)
            {
                Console.WriteLine(s.FirsName);
                Console.WriteLine(s.Group.DepartmentName);
            }


        }
    }
}
