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

        public ActionResult Home(string academyID)
        {
            Student student = StudentDAL.GetByAcademyID(academyID);
            ViewBag.Hello = "Hello " + student.FirstName + " " + student.LastName;

            //List<Student> students = StudentDAL.GetAll().ToList();
            //List<StudentViewModel> viewModel = new List<StudentViewModel>();

            //foreach (Student s in students)
            //{
            //    viewModel.Add(new StudentViewModel(s));
            //}



            return View(student);
        }
    }
}
