using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task01;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            List<Student> students = new List<Student>{
            new Student("Pero","Perev","F24006","+359342342","pero@abv.bg",2,new List<int> {5,2,6,6,6,4,6}),
            new Student("Ivan", "Petrov", "F33406","+359377342","ivo@abv.bg",1,new List<int> {4,2,6,3,2,4,6}),
            new Student("Kocho", "Mastikata","F54337","+359342342","kocho83@abv.bg",1,new List<int> {5,2,6,5,6,4,6}),
            new Student("Marijka", "Umnoto","F636306","+359377342","mary_jane@mail.bg",2,new List<int> {4,2,6,2,5,4,5}),
            new Student("Anna", "Maria","F77337","+359312342","kozlodui@hit.bg",2,new List<int> {2,2,6,5,2,4,3}),
            };

            var students06 = students.Where(x => x.FN[4] == '0' && x.FN[5] == '6');


            foreach (var s in students06)
            {
                foreach (var mark in s.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
