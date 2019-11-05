using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Primary_School_Management_System___2.DAL;
using Primary_School_Management_System___2.Models;
using Primary_School_Management_System___2.View_Model;

namespace Primary_School_Management_System___2.Controllers
{
    public class StudentController : Controller
    {
        private SchoolDbContext db = new SchoolDbContext();

        // GET: Student
        public ActionResult Index(int? SelectedClass, string searchString)
        {
            var classes = db.Classes.ToList();
            ViewBag.SelectedClass = new SelectList(classes,"ID", "ClassName", SelectedClass);

            List<Student> students = new List<Student>();

            if (SelectedClass != null)
            {
                students = db.Students
                    .Where(c => !SelectedClass.HasValue || c.ClassID == SelectedClass)
                    .OrderBy(c => c.RollNo)
                    .Include(c => c.Class).ToList();
            }
            
            //for searching
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString)).ToList();
            }

            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.ClassID = new SelectList(db.Classes, "ID", "ClassName");
            ViewBag.ReligionID = new SelectList(db.Religions, "ID", "Name");
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RollNo,Name,BirthDate,FatherName,MotherName,ClassID,Address,ReligionID,GuardianMobileNumber,GuardianEmail")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClassID = new SelectList(db.Classes, "ID", "ClassName", student.ClassID);
            ViewBag.ReligionID = new SelectList(db.Religions, "ID", "Name");
            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassID = new SelectList(db.Classes, "ID", "ClassName", student.ClassID);
            ViewBag.ReligionID = new SelectList(db.Religions, "ID", "Name");
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RollNo,Name,BirthDate,FatherName,MotherName,ClassID,Address,ReligionID,GuardianMobileNumber,GuardianEmail")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassID = new SelectList(db.Classes, "ID", "ClassName", student.ClassID);
            ViewBag.ReligionID = new SelectList(db.Religions, "ID", "Name");
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Enroll Student....
        public ActionResult EnrollStudent()
        {
            return View();
        }

        public ActionResult EnrollStudentPost()
        {
            var students = db.Students.ToList();

            foreach (var student in students)
            {
                var subjects = db.Subjects.Where(s => s.ClassID == student.ClassID).ToList();

                foreach (var subject in subjects)
                {
                    var results = db.Results.Where(r => r.StudentID == student.ID && r.SubjectID == subject.ID).ToList();

                    Result result = new Result();
                    result.StudentID = student.ID;
                    result.SubjectID = subject.ID;

                    if (results.FirstOrDefault(r=> r.ExamTypeID==1) == null)
                    {
                        result.ExamTypeID = 1;

                        db.Results.Add(result);
                        db.SaveChanges();
                    }

                    if (results.FirstOrDefault(r => r.ExamTypeID == 2) == null)
                    {
                        result.ExamTypeID = 2;

                        db.Results.Add(result);
                        db.SaveChanges();
                    }
                    
                }
            }

            return RedirectToAction("EnrollStudent");
        }

        //Add Random Number to the subjects...
        public ActionResult AddRandomGradeToSubjects()
        {
            Random random = new Random();

            var results = db.Results.ToList();

            foreach (var result in results)
            {
                result.Number = random.Next(40, 100);
                db.Entry(result).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("EnrollStudent");
        }

        //Single Student Result......
        public ActionResult SingleStudentResult(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            var subjects = db.Subjects.Where(s => s.ClassID == student.ClassID).ToList();

            List<StudentResultVM> studentResultVms = new List<StudentResultVM>();

            foreach (var subject in subjects)
            {
                StudentResultVM studentResultVm = new StudentResultVM();
                studentResultVm.Subject = subject.Name;

                studentResultVm.HalfYearly = student.Results.Single(s => s.SubjectID == subject.ID && s.ExamTypeID == 1).Number;

                studentResultVm.Final =
                    student.Results.Single(s => s.SubjectID == subject.ID && s.ExamTypeID == 2).Number;

                studentResultVms.Add(studentResultVm);
            }

            ViewBag.StudentName = student.Name;

            return View(studentResultVms);
        }
        //End of Single student result...

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
