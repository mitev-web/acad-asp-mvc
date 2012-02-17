using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkSubmission.DAL
{
    class SubmissionDAL : DAO
    {
        /// <summary>
        /// Gets all Submissions
        /// </summary>
        /// <returns>Collection of Submissions</returns>
        public static IEnumerable<Submission> GetAll()
        {
            var e = from c in db.Submissions
                    select c;

            return e;
        }

        /// <summary>
        /// Gets all Submissions by student ID.
        /// </summary>
        /// <param name="studentID">The student ID.</param>
        /// <returns></returns>
        public static IEnumerable<Submission> GetAllByStudentID(int studentID)
        {
            var e = from c in db.Submissions
                    where c.Student.ID == studentID
                    select c;

            return e;
        }

        /// <summary>
        /// Gets Submission by ID.
        /// </summary>
        /// <param name="coursID">The Submission ID.</param>
        /// <returns>The Submission with the same ID</returns>
        public static Submission GetByID(int courseID)
        {
            Submission course = (from c in db.Submissions
                                 where c.ID == courseID
                                 select c).
            FirstOrDefault();

            return course;
        }

        /// <summary>
        /// Creates the specified Submission.
        /// </summary>
        /// <param name="student">The student.</param>
        /// <param name="topic">The topic.</param>
        /// <param name="uploadDate">The upload date.</param>
        /// <param name="mimeType">Type of the MIME.</param>
        /// <param name="fileData">The file data.</param>
        public static void Create(Student student, Topic topic, DateTime uploadDate, string mimeType, byte[] fileData)
        {
            Submission s = new Submission();
            s.Student = student;
            s.Topic = topic;
            s.UploadDate = uploadDate;
            s.MIMEType = mimeType;
            s.FileData = fileData;

            db.AddToSubmissions(s);
        }
    }
}