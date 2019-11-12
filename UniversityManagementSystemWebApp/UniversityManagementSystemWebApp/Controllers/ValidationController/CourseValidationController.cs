using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;


namespace UniversityManagementSystemWebApp.Controllers.ValidationController
{
    public class CourseValidationController : Controller
    {

        private UniversityDbContext db = new UniversityDbContext();
        //
        // GET: /Validation/
        //Uniqe Validation.....Code
        [HttpGet]
        public JsonResult IsCodeExist(string code)
        {
            var courses = db.Courses.Include(c => c.Department);
            bool isExist =
                courses.ToList().FirstOrDefault(m => m.Code.ToLowerInvariant().Equals(code.ToLower())) != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        //Uniqe Validation.....Title
        [HttpGet]
        public JsonResult IsNameExist(string name)
        {
            var courses = db.Courses.Include(c => c.Department);
            bool isExist = courses.ToList().FirstOrDefault(m => m.Name.ToLowerInvariant().Equals(name.ToLower())) !=
                           null;

            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}