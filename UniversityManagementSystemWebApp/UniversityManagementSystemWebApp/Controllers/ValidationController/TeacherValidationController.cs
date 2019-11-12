using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;

namespace UniversityManagementSystemWebApp.Controllers.ValidationController
{
    public class TeacherValidationController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();
        //
        // GET: /Validation/
        //Uniqe Validation.....Email
        [HttpGet]
        public JsonResult IsEmailExist(string email)
        {
            var teachers = db.Teachers.Include(t => t.Department).Include(t => t.Designation);
            bool isExist =
                teachers.ToList().FirstOrDefault(m => m.Email.ToLowerInvariant().Equals(email.ToLower())) != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        //Uniqe Validation.....Name
        [HttpGet]
        public JsonResult IsNameExist(string name)
        {
            var teachers = db.Teachers.Include(t => t.Department).Include(t => t.Designation);
            bool isExist = teachers.ToList().FirstOrDefault(m => m.Name.ToLowerInvariant().Equals(name.ToLower())) !=
                           null;

            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        //Uniqe Validation.....ContactNo
        [HttpGet]
        public JsonResult IsContactNoExist(string contactNo)
        {
            var teachers = db.Teachers.Include(t => t.Department).Include(t => t.Designation);
            bool isExist = teachers.ToList().FirstOrDefault(m => m.Contact.Equals(contactNo)) !=
                           null;

            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}