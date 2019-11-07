using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Primary_School_Management_System___2.DAL;
using Primary_School_Management_System___2.Models;
using Primary_School_Management_System___2.View_Model;
using Rotativa;

namespace Primary_School_Management_System___2.Controllers
{
    public class ResultController : Controller
    {
        private SchoolDbContext db = new SchoolDbContext();

        // GET: Result
        public ActionResult Index(int? SelectedClass, int? SelectedExamType, string searchStudent)
        {
            var classes = db.Classes.ToList();
            ViewBag.SelectedClass = new SelectList(classes, "ID", "ClassName", SelectedClass);

            var examTypes = db.ExamTypes.ToList();
            ViewBag.SelectedExamType = new SelectList(examTypes, "ID", "TypeName", SelectedExamType);

            List<ResultVM> resultVms = new List<ResultVM>();

            if (SelectedClass != null && SelectedExamType != null)
            {
                //Student By Class.....
                var students = db.Students
                    .Where(s=> s.ClassID==SelectedClass)
                    .OrderBy(s=>s.RollNo).ToList();

                //for searching
                if (!String.IsNullOrEmpty(searchStudent))
                {
                    students = students.Where(s => s.Name.Contains(searchStudent)).ToList();
                }

                foreach (var student in students)
                {
                    ResultVM resultVm = new ResultVM();

                    resultVm.ID = student.ID;
                    resultVm.Class = student.Class.ClassName;
                    resultVm.RollNo = student.RollNo;
                    resultVm.Name = student.Name;

                    var subjects = db.Subjects.Where(s => s.ClassID == student.ClassID).ToList();

                    foreach (var subject in subjects)
                    {
                        //result by Examtype.....
                        var result = db.Results.FirstOrDefault(s =>
                            s.StudentID == student.ID && s.SubjectID == subject.ID && s.ExamTypeID == SelectedExamType);
                        string subjectName = db.Subjects.Single(s => s.ID == result.SubjectID).Name;

                        resultVm.ExamType = SelectedExamType == 1 ? "Half Yearly" : "Final";

                        switch (subjectName)
                        {
                            case "আমার বাংলা বই":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.Bangla = (int)result.Number;
                                break;
                            case "প্রাথমিক গণিত":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.Math = (int)result.Number;
                                break;
                            case "English For Today":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.English = (int)result.Number;
                                break;
                            case "প্রাথমিক বিজ্ঞান":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.GeneralScience = (int)result.Number;
                                break;
                            case "বাংলাদেশ ও বিশ্বপরিচয়":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.SocialScience = (int)result.Number;
                                break;
                            case "ইসলাম ও নৈতিক শিক্ষা":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.IslamicEdication = (int)result.Number;
                                break;
                            case "হিন্দুধর্ম ও নৈতিক শিক্ষা":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.HinduismEducation = (int)result.Number;
                                break;
                            case "বৌদ্ধধর্ম ও নৈতিক শিক্ষা":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.BuddhismEducation = (int)result.Number;
                                break;
                            case "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা":
                                if (result != null)
                                    if (result.Number != null)
                                        resultVm.ChristianityEducation = (int)result.Number;
                                break;
                        }
                        
                    }

                    resultVms.Add(resultVm);
                }

            

            
                

                
            }
            return View(resultVms);
        }

        //Single course Result......
        public ActionResult SingleCourseIndex(int? SelectedClass, int? SelectedSubject, int? SelectedExamType)
        {
            //Load Dropdowns....
            var classes = db.Classes.ToList();
            ViewBag.SelectedClass = new SelectList(classes, "ID", "ClassName", SelectedClass);

            if (SelectedSubject != null)
            {
                var subjects = db.Subjects.Where(s=> s.ClassID==SelectedClass).ToList();
                ViewBag.SelectedSubject = new SelectList(subjects, "ID", "Name", SelectedSubject);
            }
            else
            {
                ViewBag.SelectedSubject = new SelectList(Enumerable.Empty<SelectListItem>());
            }

            var examTypes = db.ExamTypes.ToList();
            ViewBag.SelectedExamType = new SelectList(examTypes, "ID", "TypeName", SelectedExamType);

            List<Result> subjectResults = new List<Result>();

            if (SelectedSubject != null && SelectedExamType != null)
            {
                subjectResults = db.Results
                    .Where(s => s.SubjectID == SelectedSubject && s.ExamTypeID == SelectedExamType)
                    .OrderBy(s => s.Student.RollNo).ToList();
            }

            
            return View(subjectResults);
        }

        //Load dropdown for subject after selecting the class.....
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetSubjectByClass(int clsID)
        {
            var subjectList = db.Subjects.Where(s => s.ClassID == clsID).ToList();

            var selectedSubject = new SelectList(subjectList, "ID", "Name");

            return Json(selectedSubject, JsonRequestBehavior.AllowGet);
        }
        //End of single course result.........

        //Generate Pdf Marksheet......
        //Pdf View.............
        public ActionResult MarkSheetPdf(Student student)
        {
            var results = db.Results.Where(s => s.StudentID == student.ID).ToList();
            ViewBag.Student = db.Students.Find(student.ID);
            return View(results);
        }

        public ActionResult ResultViewToPdf(int id)
        {
            var student = db.Students.Find(id);
            return new ActionAsPdf("MarkSheetPdf", student) { FileName = student.Name + "MarkSheet" + DateTime.Now.ToLocalTime() + ".pdf" };
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