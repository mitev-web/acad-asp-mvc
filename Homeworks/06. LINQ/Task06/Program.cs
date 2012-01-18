using System;
using System.Collections.Generic;
using System.Linq;
using Task01;
using System.Text;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
           //Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.

            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24006","+359342342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}),
            new Student("Ivan", "Petrov", "F33406","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,2,4,6}),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}),
            new Student("Marijka", "Umnoto","F636306","+359377342","mary_jane@mail.bg",2,new List<int> {4,2,6,2,5,4,5}),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}),
            };

            var doubleDStudents = students.Where(x => x.Marks.Count(j => j == 2) == 2);


            foreach (var s in doubleDStudents)
            {//outputs Pero & Anna
                Console.WriteLine(s.FirstName);
                foreach (var mark in s.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
