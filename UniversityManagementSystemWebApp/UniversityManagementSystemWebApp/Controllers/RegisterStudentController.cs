using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class RegisterStudentController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        // GET: /RegisterStudent/
        public ActionResult Index()
        {
            var registerstudents = db.RegisterStudents.Include(r => r.Department);
            return View(registerstudents.ToList());
        }

        // GET: /RegisterStudent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterStudent registerstudent = db.RegisterStudents.Find(id);
            if (registerstudent == null)
            {
                return HttpNotFound();
            }
            return View(registerstudent);
        }

        // GET: /RegisterStudent/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code");
            var register = new RegisterStudent()
            {
                Date = DateTime.Today
            };
            return View(register);
        }

        // POST: /RegisterStudent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Contact,Date,Address,DepartmentId")] RegisterStudent registerstudent)
        {
            if (ModelState.IsValid)
            {
                registerstudent.RegistationNumber = GenareteRegNo(registerstudent);
                db.RegisterStudents.Add(registerstudent);
                db.SaveChanges();
                return RedirectToAction("Details", new { Id = registerstudent.Id });
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", registerstudent.DepartmentId);
            return View(registerstudent);
        }

        public string GenareteRegNo(RegisterStudent student)
        {
            string depCode = (from d in db.Departments where (d.Id == student.DepartmentId) select d.Code).FirstOrDefault();

            var count = ((from s in db.RegisterStudents
                          where (s.Date.Year == student.Date.Year && s.DepartmentId == student.DepartmentId)
                          select s.RegistationNumber).Count());
            //if (count==null)
            //{
            //    count = 0;
            //}

            count++;

            string regNo = depCode + "-" + student.Date.Year + "-" + count.ToString("D3");

            return regNo;
        }

        // GET: /RegisterStudent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterStudent registerstudent = db.RegisterStudents.Find(id);
            if (registerstudent == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", registerstudent.DepartmentId);
            return View(registerstudent);
        }

        // POST: /RegisterStudent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Contact,Date,Address,DepartmentId")] RegisterStudent registerstudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registerstudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", registerstudent.DepartmentId);
            return View(registerstudent);
        }

        // GET: /RegisterStudent/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterStudent registerstudent = db.RegisterStudents.Find(id);
            if (registerstudent == null)
            {
                return HttpNotFound();
            }
            return View(registerstudent);
        }

        // POST: /RegisterStudent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegisterStudent registerstudent = db.RegisterStudents.Find(id);
            db.RegisterStudents.Remove(registerstudent);
            db.SaveChanges();
            return RedirectToAction("Index");
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
