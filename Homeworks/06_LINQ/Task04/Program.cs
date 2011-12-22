using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Task01;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\+3592");

            //Extract all students with phones in Sofia. Use LINQ and regular expressions.
            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24027","+359242342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}),
            new Student("Ivan", "Petrov", "F33413","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,6,4,6}),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}),
            new Student("Marijka", "Umnoto","F636323","+359277342","mary_jane@mail.bg",2,new List<int> {4,2,6,5,5,4,5}),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}),
            };

            var sofiaStudents = from s in students
                              let matches = regex.Matches(s.Tel)
                              where matches.Count > 0
                              select s;

            foreach (var s in sofiaStudents)
            {//outputs Pero & Anna
                Console.WriteLine(s.FirstName);
            }

        }
    }
}
