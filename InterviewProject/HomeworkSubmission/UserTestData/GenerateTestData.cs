using System;
using System.Collections.Generic;
using System.Linq;
using HomeworkSubmission.DAL;

namespace UserTestData
{
    class GenerateTestData
    {
        /// <summary>
        /// Adds the students to submissions.
        /// </summary>
        /// <param name="submissions">The submissions.</param>
        /// <returns></returns>
        private static List<Submission> AddStudentsToSubmissions(List<Submission> submissions)
        {
            List<Student> students = StudentDAL.GetAll().ToList();
            int topicMax = students.Count();
            Random rand = new Random();
            foreach (Submission submission in submissions)
            {
                submission.Student = students[rand.Next(0, topicMax - 1)];
            }

            return submissions;
        }
  
        /// <summary>
        /// Adds the topics to submissions.
        /// </summary>
        /// <param name="submissions">The submissions.</param>
        /// <returns></returns>
        private static List<Submission> AddTopicsToSubmissions(List<Submission> submissions)
        {
            List<Topic> topics = TopicDAL.GetAll().ToList();
            int topicMax = topics.Count();
            Random rand = new Random();
            foreach (Submission submission in submissions)
            {
                submission.Topic = topics[rand.Next(0, topicMax - 1)];
            }

            return submissions;
        }

        /// <summary>
        /// Populates the courses with students.
        /// </summary>
        /// <param name="numberStudents">The number students.</param>
        public static void PopulateCoursesWithStudents(int numberStudents)
        {
            if (numberStudents > StudentDAL.GetAll().Count())
            {
                Console.WriteLine("not enough students to populate courses");
                return;
            }
            List<Cours> courses = CourseDAL.GetAll().ToList();

            foreach (Cours course in courses)
            {
                foreach (Student student in GetRandomStudents(numberStudents))
                {
                    CourseDAL.AddtoStudent(student, course);
                }
            }
        }
        /// <summary>
        /// Gets the random students.
        /// </summary>
        /// <param name="numberStudents">The number students.</param>
        /// <returns></returns>
        public static List<Student> GetRandomStudents(int numberStudents)
        {
            List<Student> students = StudentDAL.GetAll().ToList();
            List<Student> randomStudents = new List<Student>();

            Random rand = new Random();
            for (int i = 0; i < numberStudents; i++)
            {
                Student nextRandomStudent = students[rand.Next(0, numberStudents)];
                if (!randomStudents.Contains(nextRandomStudent))
                {
                    randomStudents.Add(nextRandomStudent);
                }
            }

            return randomStudents;
        }

        /// <summary>
        /// Populates the students.
        /// </summary>
        /// <param name="numberStudents">The number students.</param>
        public static void PopulateStudents(int numberStudents)
        {
            for (int i = 0; i < numberStudents; i++)
            {
                string firstName = Faker.NameFaker.FirstName();
                string lastName = Faker.NameFaker.LastName();
                string email = Faker.StringFaker.Alpha(3) + Faker.InternetFaker.Email();

                Student student = StudentDAL.Create(firstName, lastName, email);
                StudentDAL.AddAcademyID(student);
            }
        }

        /// <summary>
        /// Populates the courses.
        /// </summary>
        /// <param name="numberCourses">The number courses.</param>
        public static void PopulateCourses(int numberCourses)
        {
            for (int i = 0; i < numberCourses; i++)
            {
                string name = Faker.CompanyFaker.BS();
                bool isActive = true;

                CourseDAL.Create(name, isActive);
            }
        }





        /// <summary>
        /// Generates submissions.
        /// </summary>
        /// <param name="numberSubmissions">The number of submissions.</param>
        /// <returns></returns>
        public static List<Submission> GenerateSubmissions(int numberSubmissions)
        {
            List<Student> students = StudentDAL.GetAll().ToList();
            List<Submission> submissions = new List<Submission>(); 
            foreach (Student student in students)
            {
                for (int i = 0; i < numberSubmissions; i++)
                {
                    Submission s = new Submission();
                    s.Student = student;
                    s.MIMEType = "application/zip";
                    s.UploadDate = Faker.DateTimeFaker.DateTime();
                    submissions.Add(s);
                }
            }

            return submissions;
        }

        /// <summary>
        /// Adds submissions to students.
        /// </summary>
        /// <param name="numberOfSubmissions">The number of submissions per student.</param>
        public static void AddSubmissionsToStudents(int numberOfSubmissions)
        {
            List<Submission> submissions = GenerateSubmissions(numberOfSubmissions);

            submissions = AddTopicsToSubmissions(submissions);

            foreach (Submission submission in submissions)
            {
                try
                {
                    DAO.db.Submissions.AddObject(submission);
                    DAO.db.SaveChanges();
                }
                catch (Exception e)
                { //TODO: fix this exception
                    //Console.WriteLine(numberOfSubmissions);
                }
            }
           
        }

        public static List<Topic> GenerateTopics(int numberTopics)
        {
            List<Topic> topics = new List<Topic>();

            for (int i = 0; i < numberTopics; i++)
            {
                Topic t = new Topic();
                DateTime startDate = Faker.DateTimeFaker.DateTimeBetweenMonths(2, 3);
                DateTime endDate = Faker.DateTimeFaker.DateTimeBetweenMonths(3, 5);
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
            List<Cours> courses = HomeworkSubmission.DAL.CourseDAL.GetAll().ToList();
            foreach (Cours course in courses)
            {
                foreach (Topic topic in GenerateTopics(numberTopics))
                {
                    TopicDAL.AddToCourse(topic, course);
                }
            }
        }
    }
}