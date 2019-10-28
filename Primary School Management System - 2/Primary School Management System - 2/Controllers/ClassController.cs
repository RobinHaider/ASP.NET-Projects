using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Primary_School_Management_System___2.DAL;
using Primary_School_Management_System___2.Models;
using Primary_School_Management_System___2.View_Model;

namespace Primary_School_Management_System___2.Controllers
{
    public class ClassController : Controller
    {
        SchoolDbContext db = new SchoolDbContext();

        // GET: Class
        public ActionResult Index()
        {
            List<ClassVM> classVms = new List<ClassVM>();
            var classes = db.Classes
                .Include(s => s.Subjects)
                .Include(s => s.Teacher)
                .ToList();

            foreach (var @class in classes)
            {
                ClassVM classVm = new ClassVM();

                classVm.ID = @class.ID;
                classVm.Class = @class.ClassName;
                classVm.ClassTeacher = @class.Teacher.Name;
                @classVm.Subjects = new List<string>();
                @class.Subjects.ForEach(s=> classVm.Subjects.Add(s.Name));
                classVm.TotalStudent = db.Students
                    .Count(s => s.ClassID == @class.ID);

                classVms.Add(classVm);
            }

            

            return View(classVms);
        }

        // GET: Class/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Class cls = db.Classes.Find(id);
            if (cls == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "Name", cls.TeacherID);
            
            return View(cls);
        }

        // POST: Class/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var classToUpdate = db.Classes.Find(id);
            if (TryUpdateModel(classToUpdate, "",
                new string[] { "TeacherID" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }

            ViewBag.TeacherID = new SelectList(db.Teachers, "ID", "Name", classToUpdate.TeacherID);
            return View(classToUpdate);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}