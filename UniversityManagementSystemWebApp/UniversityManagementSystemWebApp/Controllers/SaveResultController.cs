using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class SaveResultController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        EnrollCourseManager enrollCourseManager = new EnrollCourseManager();

        SaveResultManager saveResultManager = new SaveResultManager();

        // GET: /SaveResult/
        public ActionResult Index()
        {
            var saveresults = db.SaveResults.Include(s => s.Course).Include(s => s.Grade).Include(s => s.RegisterStudent);
            return View(saveresults.ToList());
        }



        // GET: /SaveResult/Create
        public ActionResult Create()
        {

            ViewBag.GradeId = new SelectList(db.Grades, "Id", "Name");
            ViewBag.RegisterStudentId = new SelectList(db.RegisterStudents, "Id", "RegistationNumber");
            return View();
        }

        // POST: /SaveResult/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegisterStudentId,Name,Email,Department,CourseId,GradeId")] SaveResult saveresult)
        {
            if (ModelState.IsValid)
            {
                SaveResult result = db.SaveResults.FirstOrDefault(u => u.RegisterStudentId.Equals(saveresult.RegisterStudentId) && u.CourseId.Equals(saveresult.CourseId));
                if (result != null)
                {
                    saveresult.Id = result.Id;
                    saveResultManager.UpdateResult(saveresult);
                    return RedirectToAction("Index");
                }
                db.SaveResults.Add(saveresult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewBag.GradeId = new SelectList(db.Grades, "Id", "Name", saveresult.GradeId);
            ViewBag.RegisterStudentId = new SelectList(db.RegisterStudents, "Id", "RegistationNumber", saveresult.RegisterStudentId);
            return View(saveresult);
        }


        //Json Methods.................................................................................
        public JsonResult EnrollCourseByStd(int studentId)
        {

            List<Course> courses = enrollCourseManager.EnrollCourseByStd(studentId);
            return Json(courses);
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
