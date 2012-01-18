using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task01;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
           // Implement the previous using the same query expressed with extension methods.
            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24027","+359342342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}),
            new Student("Ivan", "Petrov", "F33413","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,6,4,6}),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}),
            new Student("Marijka", "Umnoto","F636323","+359377342","mary_jane@mail.bg",2,new List<int> {4,2,6,5,5,4,5}),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}),
            };

            var orderedStudents = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (var s in orderedStudents)
                Console.WriteLine(s.FirstName);

        }
    }
}
