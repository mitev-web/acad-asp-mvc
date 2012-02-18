using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeworkSubmission.DAL;

namespace HomeworkSubmission.MVC.Models
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Cours> Courses { get; set; }
        public List<Submission> Submissions { get; set; }

        public StudentViewModel(string firstName, string lastName, List<Cours> courses, List<Submission> submissions)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
            this.Submissions = submissions;
        }

        public StudentViewModel(HomeworkSubmission.DAL.Student student)
        {
            this.FirstName = student.FirstName;
            this.LastName = student.LastName;
            this.Courses = student.Courses.ToList();
            this.Submissions = student.Submissions.ToList();
        }
    }
}