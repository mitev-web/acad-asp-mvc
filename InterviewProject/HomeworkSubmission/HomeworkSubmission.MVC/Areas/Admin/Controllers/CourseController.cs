using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkSubmission.DAL;

namespace HomeworkSubmission.MVC.Areas.Admin.Controllers
{ 
    public class CourseController : Controller
    {
        private HomeworkSubmissionEntities db = new HomeworkSubmissionEntities();
        //
        // GET: /Course/

        public ViewResult Index(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            ViewBag.Count = db.Courses.Count();
            ViewBag.Start = start;
            ViewBag.ItemsPerPage = itemsPerPage;
            ViewBag.OrderBy = orderBy;
            ViewBag.Desc = desc;

            return View();
        }

        //
        // GET: /Course/GridData/?start=0&itemsPerPage=20&orderBy=ID&desc=true

        public ActionResult GridData(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            Response.AppendHeader("X-Total-Row-Count", db.Courses.Count().ToString());
            ObjectQuery<Cours> courses = db.Courses;
            courses = courses.OrderBy("it." + orderBy + (desc ? " desc" : ""));

            return PartialView(courses.Skip(start).Take(itemsPerPage));
        }

        //
        // GET: /Default5/RowData/5

        public ActionResult RowData(int id)
        {
            Cours cours = db.Courses.Single(c => c.ID == id);
            return PartialView("GridData", new Cours[] { cours });
        }

        //
        // GET: /Course/Create

        public ActionResult Create()
        {
            return PartialView("Edit");
        }

        //
        // POST: /Course/Create

        [HttpPost]
        public ActionResult Create(Cours cours)
        {
            if (ModelState.IsValid)
            {
                db.Courses.AddObject(cours);
                db.SaveChanges();
                return PartialView("GridData", new Cours[] { cours });
            }

            return PartialView("Edit", cours);
        }

        //
        // GET: /Course/Edit/5

        public ActionResult Edit(int id)
        {
            Cours cours = db.Courses.Single(c => c.ID == id);
            return PartialView(cours);
        }

        //
        // POST: /Course/Edit/5

        [HttpPost]
        public ActionResult Edit(Cours cours)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Attach(cours);
                db.ObjectStateManager.ChangeObjectState(cours, EntityState.Modified);
                db.SaveChanges();
                return PartialView("GridData", new Cours[] { cours });
            }

            return PartialView(cours);
        }

        //
        // POST: /Course/Delete/5

        [HttpPost]
        public void Delete(int id)
        {
            Cours cours = db.Courses.Single(c => c.ID == id);
            db.Courses.DeleteObject(cours);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
