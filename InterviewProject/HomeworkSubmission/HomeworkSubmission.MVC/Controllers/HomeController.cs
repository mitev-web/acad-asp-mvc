using System;
using System.Collections.Generic;
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
            ViewBag.Message = "Please submit your Homework";

            return View();
        }

 

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Home(int? courses, string academyID)
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
            {
                topicViewModels.Add(new TopicViewModel(topic));
            }

            ViewBag.Topics = topicViewModels;

            StudentViewModel studentViewModel = new StudentViewModel(student);

            return View(studentViewModel);
        }
    }
}
