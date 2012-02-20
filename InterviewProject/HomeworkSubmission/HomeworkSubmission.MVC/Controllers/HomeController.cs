using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkSubmission.DAL;
using HomeworkSubmission.MVC.Models;

namespace HomeworkSubmission.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          // Response.Redirect("Home/Home?AcademyID=10_DADA");

           ViewBag.RandomID =  StudentDAL.GetRandomStudent().AcademyID;



           return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Upload(HttpPostedFileBase file, string topicID,
            string courseID, string academyID)
        {
            bool success = true;
            string errors = string.Empty;
            if (courseID.Length == 0)
            {
                errors += "You need to select a category!";
                success = false;
            }
            if (topicID.Length == 0)
            {
                errors += "You need to select a topic!\n";
                success = false;
            }
            if (academyID.Length == 0)
            {
                errors += "Invalid Academy ID\n";
                success = false;
            }
            if (file == null)
            {
                errors += "You must upload a file!\n";
                success = false;
            }
            if (success == false)
            {
                ViewBag.Message = errors;
                return View();
            }

            ViewBag.topic = topicID;
            ViewBag.courseID = courseID;
            ViewBag.academyID = academyID;

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                file.SaveAs(path);
            }

            return View();
        }

        public ActionResult Home(int? courses, string academyID)
        {
            try
            {
                Student student = StudentDAL.GetByAcademyID(academyID);
          
                ViewBag.Hello = "Hello " + student.FirstName + " " + student.LastName;
                ViewBag.CourseID = courses;
                if (courses == null)
                { 
                    courses = student.Courses.FirstOrDefault().ID;
                }

                List<Topic> topics = CourseDAL.GetTopicsByID((int)courses).ToList();
                List<TopicViewModel> topicViewModels = new List<TopicViewModel>();

                foreach (Topic topic in topics)
                    topicViewModels.Add(new TopicViewModel(topic));

                int counter = 0;
                foreach(TopicViewModel tvm in topicViewModels)
                    tvm.Name = (++counter).ToString()+". " + tvm.Name;
                
                ViewBag.Topics = topicViewModels;

                StudentViewModel studentViewModel = new StudentViewModel(student);

                //var tuple =  new Tuple<StudentViewModel, SubmissionViewModel>
                //    (studentViewModel, new SubmissionViewModel());

                return View(studentViewModel);
            }
            catch(Exception)
            {
                ViewBag.Message = "Invalid Academy ID";
                return View("Index");
            }
        }
    }
}