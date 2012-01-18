using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task01;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks. Use LINQ.


            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24027","+359342342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}),
            new Student("Ivan", "Petrov", "F33413","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,6,4,6}),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}),
            new Student("Marijka", "Umnoto","F636323","+359377342","mary_jane@mail.bg",2,new List<int> {4,2,6,5,5,4,5}),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}),
            };

            var sofiaStudents = from s in students
                                where s.Marks.Contains(6)
                                select new
                                {
                                    FullName = s.FirstName+" "+s.LastName,
                                    Marks = s.Marks
                                };

            foreach (var s in sofiaStudents)
            {//outputs Pero & Anna
                Console.WriteLine(s.FullName);
                foreach (var mark in s.Marks)
                {
                    Console.Write(mark+ " ");
                }
                Console.WriteLine();
            }

        }
    }
}
