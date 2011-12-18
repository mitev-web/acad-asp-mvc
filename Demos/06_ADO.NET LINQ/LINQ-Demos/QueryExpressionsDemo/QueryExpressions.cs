using System;
using System.Collections.Generic;
using System.Linq;

class QueryExpressions
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Grades { get; set; }
     }
    static void Main()
    {

        Student[] students = new Student[]
        {
            new Student(){ FirstName = "pesho", LastName = "ivanov", Grades = new int[]{2,3,6,2,4,5,}},
            new Student(){ FirstName = "ivan", LastName = "petrov", Grades = new int[]{3,6,6,5,4,5,}},
            new Student(){ FirstName = "pesho", LastName = "ivanov", Grades = new int[]{6,6,6,2,2,5,}}
        };
        //Console.WriteLine((products as ObjectQuery);
    //    students.Where(s=> FirstName == "pesho");
            var query = 
                from s in students
                where s.Grades.Contains(6)
                select new { 
                    FName = s.FirstName,
                    AvGrade = s.Grades.Length > 0 ? s.Grades.Average(): 1};

            foreach (var s in query)
            {
                Console.WriteLine(s.FName, s.AvGrade);

            }

        // Assume we have an array of strings.
        string[] games = {"Morrowind", "BioShock" ,
            "Half Life 2: Episode 1", "The Darkness",
            "Daxter", "System Shock 2"};
            
        // Build a query expression to represent the items
        // in the array that consist of more than 6 letters
        IEnumerable<string> subset =
            from g in games
            where g.Substring(1, 2) == "or" && g.Length > 2
            select g.Substring(5);
            
        // Print out the results
        foreach (string s in subset)
        {
            Console.WriteLine("Item: {0}", s);
        }
    }
}
