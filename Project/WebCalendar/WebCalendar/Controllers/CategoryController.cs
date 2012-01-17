using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalendar.Controllers
{
    public class CategoryController : Controller
    {
        private WebCalendarEntities db = new WebCalendarEntities();

        //
        // GET: /Category/

        public ViewResult Index(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            ViewBag.Count = db.Categories.Count();
            ViewBag.Start = start;
            ViewBag.ItemsPerPage = itemsPerPage;
            ViewBag.OrderBy = orderBy;
            ViewBag.Desc = desc;

            return View();
        }

        //
        // GET: /Category/GridData/?start=0&itemsPerPage=20&orderBy=ID&desc=true

        public ActionResult GridData(int start = 0, int itemsPerPage = 20, string orderBy = "ID", bool desc = false)
        {
            Response.AppendHeader("X-Total-Row-Count", db.Categories.Count().ToString());
            ObjectQuery<Category> categories = db.Categories;
            categories = categories.OrderBy("it." + orderBy + (desc ? " desc" : ""));

            return PartialView(categories.Skip(start).Take(itemsPerPage));
        }

        //
        // GET: /Default5/RowData/5

        public ActionResult RowData(int id)
        {
            Category category = db.Categories.Single(c => c.ID == id);
            return PartialView("GridData", new Category[] { category });
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return PartialView("Edit");
        }

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.AddObject(category);
                db.SaveChanges();
                return PartialView("GridData", new Category[] { category });
            }

            return PartialView("Edit", category);
        }

        //
        // GET: /Category/Edit/5

        public ActionResult Edit(int id)
        {
            Category category = db.Categories.Single(c => c.ID == id);
            return PartialView(category);
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(category);
                db.ObjectStateManager.ChangeObjectState(category, EntityState.Modified);
                db.SaveChanges();
                return PartialView("GridData", new Category[] { category });
            }

            return PartialView(category);
        }

        //
        // POST: /Category/Delete/5

        [HttpPost]
        public void Delete(int id)
        {
            Category category = db.Categories.Single(c => c.ID == id);
            db.Categories.DeleteObject(category);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
