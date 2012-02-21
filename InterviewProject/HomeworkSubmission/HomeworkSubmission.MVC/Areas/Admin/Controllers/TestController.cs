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
    public class TestController : Controller
    {
        private HomeworkSubmissionEntities db = new HomeworkSubmissionEntities();

        //
        // GET: /Admin/Test/

        public ViewResult Index()
        {
            return View(db.Students.ToList());
        }

        //
        // GET: /Admin/Test/Details/5

        public ViewResult Details(int id)
        {
            Student student = db.Students.Single(s => s.ID == id);
            return View(student);
        }

        //
        // GET: /Admin/Test/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Test/Create

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.AddObject(student);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(student);
        }
        
        //
        // GET: /Admin/Test/Edit/5
 
        public ActionResult Edit(int id)
        {
            Student student = db.Students.Single(s => s.ID == id);
            return View(student);
        }

        //
        // POST: /Admin/Test/Edit/5

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Attach(student);
                db.ObjectStateManager.ChangeObjectState(student, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //
        // GET: /Admin/Test/Delete/5
 
        public ActionResult Delete(int id)
        {
            Student student = db.Students.Single(s => s.ID == id);
            return View(student);
        }

        //
        // POST: /Admin/Test/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Student student = db.Students.Single(s => s.ID == id);
            db.Students.DeleteObject(student);
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