using System;
using System.Collections.Generic;
using System.Linq;
using HomeworkSubmission.DAL;

namespace UserTestData
{
    class GenerateTestData
    {

        /// <summary>
        /// Generates the students.
        /// </summary>
        /// <param name="numberStudents">The number of students.</param>
        public static void GenerateStudents(int numberStudents)
        {
            for (int i = 0; i < numberStudents; i++)
            {
                string firstName = Faker.NameFaker.FirstName();
                string lastName = Faker.NameFaker.LastName();
                string email = Faker.StringFaker.Alpha(3)+Faker.InternetFaker.Email();

                Student student = StudentDAL.Create(firstName, lastName,email);
                StudentDAL.AddAcademyID(student);

            }
        }
        /// <summary>
        /// Generates the courses.
        /// </summary>
        /// <param name="numberCourses">The number of courses.</param>
        public static void GenerateCourses(int numberCourses)
        {
            for (int i = 0; i < numberCourses; i++)
            {
                string name = Faker.CompanyFaker.BS();
                bool isActive = true;

                CourseDAL.Create(name, isActive);
            }
        }

        /// <summary>
        /// Generates topics.
        /// </summary>
        /// <param name="numberTopics">The number topics.</param>
        /// <returns></returns>
        public static List<Topic> GenerateTopics(int numberTopics)
        {
            List<Topic> topics = new List<Topic>();

            for (int i = 0; i < numberTopics; i++)
            {
                Topic t = new Topic();
                DateTime startDate = Faker.DateTimeFaker.DateTimeBetweenMonths(2,3);
                DateTime endDate = Faker.DateTimeFaker.DateTimeBetweenMonths(3,5);
                bool isActive = true;
                string name = Faker.CompanyFaker.BS();

                t.ActiveFrom = startDate;
                t.ActiveTo = endDate;
                t.IsActive = isActive;
                t.Name = name;

                topics.Add(t);
            }
            return topics;
        }

        /// <summary>
        /// Populates the courses with topics.
        /// </summary>
        /// <param name="numberTopics">The number of topics.</param>
        public static void PopulateCoursesWithTopics(int numberTopics)
        {
            List<Topic> topics = GenerateTopics(numberTopics);

            CourseDAL.PopulateCourses();
           
        }



    }
}
