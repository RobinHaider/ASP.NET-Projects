using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class EnrollCourseController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        EnrollCourseManager enrollCourseManager = new EnrollCourseManager();

        // GET: /EnrollCourse/
        public ActionResult Index()
        {
            var enrollcourses = db.EnrollCourses.Include(e => e.Course).Include(e => e.RegisterStudent);
            return View(enrollcourses.ToList());
        }



        // GET: /EnrollCourse/Create
        public ActionResult Create()
        {

            ViewBag.RegisterStudentId = new SelectList(db.RegisterStudents, "Id", "RegistationNumber");
            return View();
        }

        // POST: /EnrollCourse/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegisterStudentId,Name,Email,Department,CourseId,Date")] EnrollCourse enrollcourse)
        {
            if (ModelState.IsValid)
            {
                db.EnrollCourses.Add(enrollcourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewBag.RegisterStudentId = new SelectList(db.RegisterStudents, "Id", "Name", enrollcourse.RegisterStudentId);
            return View(enrollcourse);
        }
        //Remote Validation Student with course
        [HttpGet]
        public JsonResult IsCourseAlreadyTakenByThisStd(int registerStudentId, int courseId)
        {
            var enrollcourses = db.EnrollCourses.Include(e => e.Course).Include(e => e.RegisterStudent);


            bool isExist = enrollcourses.ToList().FirstOrDefault(u => u.RegisterStudentId.Equals(registerStudentId) && u.CourseId.Equals(courseId)) != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }


        //Json Methods.................................................................................
        public JsonResult StudentInfoByStdId(int studentId)
        {

            RegisterStudent student = enrollCourseManager.StudentInfoByStdId(studentId);
            EnrollCourse enrollCourse = new EnrollCourse()
            {
                Name = student.Name,
                Email = student.Email,
                Department = enrollCourseManager.GetDepartmentName(student.DepartmentId)
            };

            return Json(enrollCourse);
        }

        public JsonResult GetCourseByStdId(int studentId)
        {

            RegisterStudent student = enrollCourseManager.StudentInfoByStdId(studentId);

            List<Course> courses = enrollCourseManager.GetCourseByDepId(student.DepartmentId);

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
