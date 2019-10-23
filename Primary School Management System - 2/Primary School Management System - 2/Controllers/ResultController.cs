using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Primary_School_Management_System___2.DAL;
using Primary_School_Management_System___2.View_Model;

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


        //For all Student Result.....
        //public ActionResult Index()
        //{
        //    List<ResultVM> resultVms = new List<ResultVM>();

        //    var students = db.Students.ToList();

        //    foreach (var student in students)
        //    {
        //        ResultVM resultVm = new ResultVM();

        //        resultVm.Class = student.Class.ClassName;
        //        resultVm.RollNo = student.RollNo;
        //        resultVm.Name = student.Name;

        //        var subjects = db.Subjects.Where(s => s.ClassID == student.ClassID).ToList();

        //        foreach (var subject in subjects)
        //        {
        //            for (int i = 1; i <= 2; i++)
        //            {
        //                var result = db.Results.FirstOrDefault(s =>
        //                s.StudentID == student.ID && s.SubjectID == subject.ID && s.ExamTypeID == i);
        //                string subjectName = db.Subjects.Single(s => s.ID == result.SubjectID).Name;

        //                resultVm.ExamType = i == 1 ? "Half Yearly" : "Final";

        //                switch (subjectName)
        //                {
        //                    case "আমার বাংলা বই":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.Bangla = (int)result.Number;
        //                        break;
        //                    case "প্রাথমিক গণিত":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.Math = (int)result.Number;
        //                        break;
        //                    case "English For Today":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.English = (int)result.Number;
        //                        break;
        //                    case "প্রাথমিক বিজ্ঞান":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.GeneralScience = (int)result.Number;
        //                        break;
        //                    case "বাংলাদেশ ও বিশ্বপরিচয়":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.SocialScience = (int)result.Number;
        //                        break;
        //                    case "ইসলাম ও নৈতিক শিক্ষা":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.IslamicEdication = (int)result.Number;
        //                        break;
        //                    case "হিন্দুধর্ম ও নৈতিক শিক্ষা":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.HinduismEducation = (int)result.Number;
        //                        break;
        //                    case "বৌদ্ধধর্ম ও নৈতিক শিক্ষা":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.BuddhismEducation = (int)result.Number;
        //                        break;
        //                    case "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা":
        //                        if (result != null)
        //                            if (result.Number != null)
        //                                resultVm.ChristianityEducation = (int)result.Number;
        //                        break;
        //                }
        //                resultVms.Add(resultVm);
        //            }

        //        }



        //    }
        //    return View(resultVms);
        //}



    }
}