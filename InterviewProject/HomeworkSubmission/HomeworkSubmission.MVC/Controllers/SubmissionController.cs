﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Providers.Entities;
using HomeworkSubmission.DAL;
using HomeworkSubmission.MVC.Models;

namespace HomeworkSubmission.MVC.Controllers
{
    public class SubmissionController : Controller
    {
        //
        // GET: /Submission/
        public ActionResult Index(string topicID="",
            string courseID = "")
        {
            if (topicID.Length > 0)
            {
                Session["TopicName"] = TopicDAL.GetNameByID(int.Parse(topicID));
                Session["TopicID"] = topicID;
            }
            if (courseID.Length > 0)
            {
                Session["CourseName"] = CourseDAL.GetNameByID(int.Parse(courseID));
                Session["CourseID"] = courseID;
            }
 
            return View();
        }

        //
        // GET: /Submission/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Submission/Create

        public ActionResult Create(SubmissionViewModel model)
        {
            bool success = true;
            string errors = string.Empty;
            model.StudentAcademyID = Session["AcademyID"].ToString();
            model.TopicID = Session["TopicID"].ToString();
            model.CourseID = Session["CourseID"].ToString();
            
            if (model.CourseID.Length == 0)
            {
                errors += "You need to select a course!";
                success = false;
            }
            if (model.TopicID.Length == 0)
            {
                errors += "You need to select a topic!\n";
                success = false;
            }
            if (model.StudentAcademyID.Length == 0)
            {
                errors += "Invalid Academy ID\n";
                success = false;
            }
            if (model.FileUpload == null || model.FileUpload.ContentLength <= 0)
            {
                errors += "You must upload a file!\n";
                success = false;
            }
            else
            {
                string fileName = model.FileUpload.FileName;

                if (!Regex.IsMatch(fileName, @".*\.(rar|zip)"))
                {
                    success = false;
                    errors += "Invalid filetype!\n";
                }
            }

            if (success == true)
            {
                string filename = model.FileUpload.FileName.ToString();
                string extension = filename.Substring(filename.Length - 3, 3);
                var dir = Path.Combine(Server.MapPath("~/Uploads"),
                    model.CourseID + "_COURSE", model.TopicID + "_TOPIC");

                var path = Path.Combine(Server.MapPath("~/Uploads"),
                    model.CourseID + "_COURSE", model.TopicID + "_TOPIC", 
                    model.StudentAcademyID.Trim() + "." + extension);
                
                if (!Directory.Exists(dir)) 
                {
                    Directory.CreateDirectory(dir);
                }
            
                // var fileName = Path.GetFileName(model.FileUpload.FileName);
                model.FileUpload.SaveAs(path);
                SubmissionDAL.Create(StudentDAL.GetByAcademyID(model.StudentAcademyID)
                    , TopicDAL.GetByID(int.Parse(model.TopicID)), DateTime.Now, extension);
            }
            else
            {
                ViewBag.Message = errors;
                return View("Index");
            }

            return View("Success");
        }

        // GET: /Submission/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Submission/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Submission/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Submission/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}