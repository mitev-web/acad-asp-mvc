using System;
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
        public static void GenerateCourses(int numberCourses)
        {
            for (int i = 0; i < numberCourses; i++)
            {
                
            }
        }



    }
}
