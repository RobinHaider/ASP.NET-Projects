using System.Collections.Generic;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class CourseAssignController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        CourseAssignManager courseAssignManager = new CourseAssignManager();



        // GET: /CourseAssign/Create
        public ActionResult Create()
        {

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code");

            return View();
        }

        // POST: /CourseAssign/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseAssign courseassign)
        {
            if (ModelState.IsValid)
            {
                //db.CourseAssigns.Add(courseassign);
                //db.SaveChanges();
                ViewBag.Msg = courseAssignManager.AssignCourse(courseassign);
                ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", courseassign.DepartmentId);
                return RedirectToAction("Create");
            }


            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", courseassign.DepartmentId);

            return View(courseassign);
        }

        //Json Methods...................
        public JsonResult GetTeachsersByDepartmentId(int departmentId)
        {
            List<Teacher> teacherList = courseAssignManager.GetTeacherByDepartmentId(departmentId);

            return Json(teacherList);
        }

        public JsonResult GetCoursesByDepartmentId(int departmentId)
        {

            List<Course> courses = courseAssignManager.GetCourseByDepartmentId(departmentId);

            return Json(courses);
        }

        public JsonResult GetRemainingCreditByTeacherId(int teacherId)
        {

            Teacher teacher = courseAssignManager.GetRemainingCreditByTeacherId(teacherId);

            return Json(teacher);
        }

        public JsonResult GetCourseInfoByCourseId(int courseId)
        {

            Course course = courseAssignManager.GetCourseInfoByCourseId(courseId);
            return Json(course);
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
