using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;

namespace UniversityManagementSystemWebApp.Controllers.CasecadingController
{
    public class AssignCourseCasecadingController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();
        //
        // GET: /AssignCourseCasecading/
        //[HttpPost]
        public ActionResult GetTeachsersByDepartmentId(int DepartmentId)
        {
            //var teachers = GetStudents();
            //var studentList = students.Where(a => a.DepartmentId == departmentId).ToList();
            //return Json(studentList);

            var teachers = db.Teachers.Include(t => t.Department).Include(t => t.Designation);
            var teacherList = teachers.Where(a => a.DepartmentId == DepartmentId).ToList();
            return Json(teacherList, JsonRequestBehavior.AllowGet);
        }




    }
}