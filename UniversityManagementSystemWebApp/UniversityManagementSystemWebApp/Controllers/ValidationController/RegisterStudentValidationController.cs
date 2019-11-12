using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;

namespace UniversityManagementSystemWebApp.Controllers.ValidationController
{
    public class RegisterStudentValidationController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();
        //
        // GET: /RegisterStudentValidation/
        [HttpGet]
        public JsonResult IsEmailExist(string email)
        {
            var registerstudents = db.RegisterStudents.Include(r => r.Department);
            bool isExist =
                registerstudents.ToList().FirstOrDefault(m => m.Email.ToLowerInvariant().Equals(email.ToLower())) != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        //Uniqe Validation.....ContactNo
        [HttpGet]
        public JsonResult IsContactNoExist(string contactNo)
        {
            var registerstudents = db.RegisterStudents.Include(r => r.Department);
            bool isExist = registerstudents.ToList().FirstOrDefault(m => m.Contact.Equals(contactNo)) !=
                           null;

            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}