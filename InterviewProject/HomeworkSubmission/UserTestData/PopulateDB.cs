using System;
using System.Linq;
using HomeworkSubmission.DAL;

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

            //GenerateTestData.PopulateStudents(400);

            //GenerateTestData.PopulateCourses(30);

            //GenerateTestData.PopulateCoursesWithTopics(15);

            //GenerateTestData.PopulateCoursesWithStudents(50);

            //GenerateTestData.AddSubmissionsToStudents(20);


            Console.WriteLine(CourseDAL.GetNameByID(17));

           

        }
    }
}
