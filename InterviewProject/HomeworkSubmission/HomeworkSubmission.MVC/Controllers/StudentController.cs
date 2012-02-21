using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkSubmission.DAL;

namespace HomeworkSubmission.MVC.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private HomeworkSubmissionEntities db = new HomeworkSubmissionEntities();

        //
        // GET: /Student/

        public ViewResult Index(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            ViewBag.Count = db.Students.Count();
            ViewBag.Start = start;
            ViewBag.ItemsPerPage = itemsPerPage;
            ViewBag.OrderBy = orderBy;
            ViewBag.Desc = desc;

            return View();
        }

        //
        // GET: /Student/GridData/?start=0&itemsPerPage=20&orderBy=ID&desc=true

        public ActionResult GridData(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            Response.AppendHeader("X-Total-Row-Count", db.Students.Count().ToString());
            ObjectQuery<Student> students = db.Students;
            students = students.OrderBy("it." + orderBy + (desc ? " desc" : ""));

            return PartialView(students.Skip(start).Take(itemsPerPage));
        }

        //
        // GET: /Default5/RowData/5

        public ActionResult RowData(int id)
        {
            Student student = db.Students.Single(s => s.ID == id);
            return PartialView("GridData", new Student[] { student });
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            return PartialView("Edit");
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.AddObject(student);
                db.SaveChanges();
                return PartialView("GridData", new Student[] { student });
            }

            return PartialView("Edit", student);
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(int id)
        {
            Student student = db.Students.Single(s => s.ID == id);
            return PartialView(student);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Attach(student);
                db.ObjectStateManager.ChangeObjectState(student, EntityState.Modified);
                db.SaveChanges();
                return PartialView("GridData", new Student[] { student });
            }

            return PartialView(student);
        }

        //
        // POST: /Student/Delete/5

        [HttpPost]
        public void Delete(int id)
        {
            Student student = db.Students.Single(s => s.ID == id);
            db.Students.DeleteObject(student);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
