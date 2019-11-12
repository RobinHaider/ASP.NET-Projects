using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class ViewScheduleController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        ViewScheduleManger viewScheduleManger = new ViewScheduleManger();
        //
        // GET: /ViewSchedule/
        public ActionResult Index()
        {
            ViewBag.Department = db.Departments.ToList();
            return View();
        }

        public JsonResult GetCourseScheduleInfoByDepId(int departmentId)
        {

            List<ViewScheduleVM> viewScheduleVms = viewScheduleManger.GetCourseScheduleInfoByDepId(departmentId);

            return Json(viewScheduleVms);
        }
    }
}