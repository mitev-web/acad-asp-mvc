using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkSubmission.DAL;

namespace HomeworkSubmission.MVC.Areas.Admin.Controllers
{ 
    public class SubmissionsController : Controller
    {
        private HomeworkSubmissionEntities db = new HomeworkSubmissionEntities();

        //
        // GET: /Admin/Submissions/

        public ViewResult Index()
        {
            var submissions = db.Submissions.Include("Cours").Include("Student").Include("Topic");
            return View(submissions.ToList());
        }

        //
        // GET: /Admin/Submissions/Details/5

        public ViewResult Details(int id)
        {
            Submission submission = db.Submissions.Single(s => s.ID == id);
            return View(submission);
        }

        //
        // GET: /Admin/Submissions/Create

        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Name");
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName");
            ViewBag.TopicID = new SelectList(db.Topics, "ID", "Name");
            return View();
        } 

        //
        // POST: /Admin/Submissions/Create

        [HttpPost]
        public ActionResult Create(Submission submission)
        {
            if (ModelState.IsValid)
            {
                db.Submissions.AddObject(submission);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Name", submission.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", submission.StudentID);
            ViewBag.TopicID = new SelectList(db.Topics, "ID", "Name", submission.TopicID);
            return View(submission);
        }
        
        //
        // GET: /Admin/Submissions/Edit/5
 
        public ActionResult Edit(int id)
        {
            Submission submission = db.Submissions.Single(s => s.ID == id);
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Name", submission.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", submission.StudentID);
            ViewBag.TopicID = new SelectList(db.Topics, "ID", "Name", submission.TopicID);
            return View(submission);
        }

        //
        // POST: /Admin/Submissions/Edit/5

        [HttpPost]
        public ActionResult Edit(Submission submission)
        {
            if (ModelState.IsValid)
            {
                db.Submissions.Attach(submission);
                db.ObjectStateManager.ChangeObjectState(submission, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Name", submission.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", submission.StudentID);
            ViewBag.TopicID = new SelectList(db.Topics, "ID", "Name", submission.TopicID);
            return View(submission);
        }

        //
        // GET: /Admin/Submissions/Delete/5
 
        public ActionResult Delete(int id)
        {
            Submission submission = db.Submissions.Single(s => s.ID == id);
            return View(submission);
        }

        //
        // POST: /Admin/Submissions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Submission submission = db.Submissions.Single(s => s.ID == id);
            db.Submissions.DeleteObject(submission);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}