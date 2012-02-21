using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkSubmission.MVC.Models
{
    public class SubmissionViewModel
    {
        [Required]
        public string StudentAcademyID { get; set; }
        [Required]
        public string TopicID { get; set; }
        [Required]
        public string CourseID { get; set; }
        public HttpPostedFileBase FileUpload { get; set; }


        public SubmissionViewModel(string studentAcademyID, string topicID, string courseID, HttpPostedFileBase fileUpload)
        {
            this.StudentAcademyID = studentAcademyID;
            this.TopicID = topicID;
            this.CourseID = courseID;
            this.FileUpload = fileUpload;
        }

        public SubmissionViewModel(string studentAcademyID, string topicID, string courseID)
        {
            this.StudentAcademyID = studentAcademyID;
            this.TopicID = topicID;
            this.CourseID = courseID;
        }
    }
}