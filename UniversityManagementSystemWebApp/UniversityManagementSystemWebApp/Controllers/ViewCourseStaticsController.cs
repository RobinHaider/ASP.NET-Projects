using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class ViewCourseStaticsController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        ViewCourseStaticsManager viewCourseStaticsManager = new ViewCourseStaticsManager();
        //
        // GET: /ViewCourseStatics/
        public ActionResult Index()
        {
            ViewBag.Department = db.Departments.ToList();
            return View();
        }

        public JsonResult GetCourseStaticsByDepId(int departmentId)
        {

            List<ViewCourseStaticsVM> viewCourseStatics = viewCourseStaticsManager.GetCourseStaticsByDepId(departmentId);

            return Json(viewCourseStatics);
        }
    }
}