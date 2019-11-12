using Rotativa;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models;
using UniversityManagementSystemWebApp.Models.ViewModel;





namespace UniversityManagementSystemWebApp.Controllers
{
    public class ViewResultController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        ViewResultManager viewResultManager = new ViewResultManager();
        //
        // GET: /ViewResult/
        [HttpGet]
        public ActionResult Index()
        {
            var registerstudents = db.RegisterStudents;
            ViewBag.Student = registerstudents;
            return View();
        }


        //[HttpPost]
        //public ActionResult Index(int studentId)
        //{



        //    var registerstudents = db.RegisterStudents;
        //    ViewBag.Student = registerstudents;
        //    return View();
        //}

        //Pdf View.............
        public ActionResult MarkSheetPdf(ResultPdfVM resultPdf)
        {
            RegisterStudent student = viewResultManager.StudentInfoByStdIdViewResult(resultPdf.StudentId);
            List<ViewResultVM> viewResultVms = viewResultManager.GetResultByStdId(resultPdf.StudentId);
            ViewBag.Result = viewResultVms;
            ViewBag.StudentInfo = student;
            ViewBag.Department = resultPdf.Department;
            return View();
        }

        public ActionResult ResultViewToPdf(ResultPdfVM resultPdf)
        {
            return new ActionAsPdf("MarkSheetPdf", resultPdf) { FileName = resultPdf.Name + "MarkSheet" + DateTime.Now.ToLocalTime() + ".pdf" };
        }


        //Json Methods.................................................................................
        public JsonResult GetAllStudentInfoByStdIdViewResult(int studentId)
        {

            RegisterStudent student = viewResultManager.StudentInfoByStdIdViewResult(studentId);

            return Json(student);
        }

        public JsonResult GetResultByStdId(int studentId)
        {

            List<ViewResultVM> viewResultVms = viewResultManager.GetResultByStdId(studentId);

            return Json(viewResultVms);
        }
    }
}