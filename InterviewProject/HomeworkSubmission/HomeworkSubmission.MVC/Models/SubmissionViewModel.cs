using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkSubmission.MVC.Models
{
    public class SubmissionViewModel
    {
        public string StudentAcademyID { get; set; }
        public string TopicID { get; set; }
        public string CategoryID { get; set; }
        public HttpPostedFileBase FileUpload { get; set; }
    }
}