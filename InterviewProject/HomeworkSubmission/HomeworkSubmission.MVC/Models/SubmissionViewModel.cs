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
        [Required]
        [Display(Name = "Select a file to upload")]
        public HttpPostedFileBase FileUpload { get; set; }
    }
}