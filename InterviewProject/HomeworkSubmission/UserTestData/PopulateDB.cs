using System;
using System.Linq;

namespace UserTestData
{
    class PopulateDB
    {
        static void Main(string[] args)
        {
            //should take less than 10 seconds for generating default data
            //400 Academy Students
            //30 Courses
            //30 Topics per Course
            //50 Students per Course
            //20 Submissions per Student

            GenerateTestData.PopulateStudents(400);

            GenerateTestData.PopulateCourses(30);

            GenerateTestData.PopulateCoursesWithTopics(15);

            GenerateTestData.PopulateCoursesWithStudents(50);

            GenerateTestData.AddSubmissionsToStudents(20);

           

        }
    }
}
