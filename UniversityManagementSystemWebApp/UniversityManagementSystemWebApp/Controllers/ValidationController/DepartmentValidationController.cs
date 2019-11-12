using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;

namespace UniversityManagementSystemWebApp.Controllers.ValidationController
{
    public class DepartmentValidationController : Controller
    {

        private UniversityDbContext db = new UniversityDbContext();
        //
        // GET: /Validation/
        //Uniqe Validation.....Code
        [HttpGet]
        public JsonResult IsCodeExist(string code)
        {

            bool isExist =
                db.Departments.ToList().FirstOrDefault(m => m.Code.ToLowerInvariant().Equals(code.ToLower())) != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        //Uniqe Validation.....Title
        [HttpGet]
        public JsonResult IsNameExist(string name)
        {

            bool isExist = db.Departments.ToList().FirstOrDefault(m => m.Name.ToLowerInvariant().Equals(name.ToLower())) !=
                           null;

            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}