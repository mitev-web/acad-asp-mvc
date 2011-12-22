using System;
using System.Collections.Generic;
using System.Linq;
using Task01;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that extracts all students grouped by GroupName and then prints them to the console. Use Extension Methods
            List<Group> groups = new List<Group>{
            new Group(1, "Mathematics"),
            new Group(2, "Art"),
            };



            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24027","+359342342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}, groups[1]),
            new Student("Ivan", "Petrov", "F33413","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,6,4,6}, groups[0]),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}, groups[0]),
            new Student("Marijka", "Umnoto","F636323","+359377342","mary_jane@mail.bg",2,new List<int> {4,2,6,5,5,4,5}, groups[1]),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}, groups[1]),
            };

            var studentGroups = students.GroupBy(s => s.Group.DepartmentName)
                                  .Select(g => new
                                  {
                                      Students = g,
                                      GroupName = g.Key,
                                  });

            foreach (var g in studentGroups)
            {
                Console.WriteLine("in group {0} there are:", g.GroupName);
                foreach (var s in g.Students)
                {
                    Console.WriteLine(s.FirstName);
                }

            }


        }
    }
}
