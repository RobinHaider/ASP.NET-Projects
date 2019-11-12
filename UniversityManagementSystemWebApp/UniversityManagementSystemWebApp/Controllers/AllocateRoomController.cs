using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using UniversityManagementSystemWebApp.Context;
using UniversityManagementSystemWebApp.Manager;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Controllers
{
    public class AllocateRoomController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        EnrollCourseManager enrollCourseManager = new EnrollCourseManager();

        // GET: /AllocateRoom/
        public ActionResult Index()
        {
            var allocaterooms = db.AllocateRooms.Include(a => a.Course).Include(a => a.Day).Include(a => a.Department).Include(a => a.Room);
            return View(allocaterooms.ToList());
        }

        // GET: /AllocateRoom/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AllocateRoom allocateroom = db.AllocateRooms.Find(id);
        //    if (allocateroom == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(allocateroom);
        //}

        // GET: /AllocateRoom/Create
        public ActionResult Create()
        {

            ViewBag.DayId = new SelectList(db.Days, "Id", "Name");
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code");
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name");
            return View();
        }

        // POST: /AllocateRoom/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DepartmentId,CourseId,RoomId,DayId,From,To")] AllocateRoom allocateroom)
        {
            if (ModelState.IsValid)
            {
                db.AllocateRooms.Add(allocateroom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DayId = new SelectList(db.Days, "Id", "Name", allocateroom.DayId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", allocateroom.DepartmentId);
            ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name", allocateroom.RoomId);
            return View(allocateroom);
        }


        //Json Methods...............................
        public JsonResult GetCourseByDepId(int departmentId)
        {

            List<Course> courses = enrollCourseManager.GetCourseByDepId(departmentId);

            return Json(courses);
        }

        //Remote Validation For Class Room already busy at that time...............


        [HttpPost]
        public JsonResult IsRoomBusyAtThatTime(int courseId, int roomId, int dayId, DateTime from, DateTime to)
        {
            var allocaterooms = db.AllocateRooms;

            bool isCourseBusy = allocaterooms.ToList().FirstOrDefault(u => u.CourseId.Equals(courseId) && u.DayId.Equals(dayId) && (u.From.AddMinutes(1) <= to && u.To >= from.AddMinutes(1))) != null;

            bool isExist = allocaterooms.ToList().FirstOrDefault(u => u.RoomId.Equals(roomId) && u.DayId.Equals(dayId) && (u.From.AddMinutes(1) <= to && u.To >= from.AddMinutes(1))) != null;

            bool assignRoom = isExist || isCourseBusy;

            return Json(!assignRoom, JsonRequestBehavior.AllowGet);
        }

        // GET: /AllocateRoom/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AllocateRoom allocateroom = db.AllocateRooms.Find(id);
        //    if (allocateroom == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.CourseId = new SelectList(db.Courses, "Id", "Code", allocateroom.CourseId);
        //    ViewBag.DayId = new SelectList(db.Days, "Id", "Name", allocateroom.DayId);
        //    ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", allocateroom.DepartmentId);
        //    ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name", allocateroom.RoomId);
        //    return View(allocateroom);
        //}

        // POST: /AllocateRoom/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="Id,DepartmentId,CourseId,RoomId,DayId,From,To")] AllocateRoom allocateroom)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(allocateroom).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CourseId = new SelectList(db.Courses, "Id", "Code", allocateroom.CourseId);
        //    ViewBag.DayId = new SelectList(db.Days, "Id", "Name", allocateroom.DayId);
        //    ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Code", allocateroom.DepartmentId);
        //    ViewBag.RoomId = new SelectList(db.Rooms, "Id", "Name", allocateroom.RoomId);
        //    return View(allocateroom);
        //}

        // GET: /AllocateRoom/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllocateRoom allocateroom = db.AllocateRooms.Find(id);
            if (allocateroom == null)
            {
                return HttpNotFound();
            }
            return View(allocateroom);
        }

        // POST: /AllocateRoom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AllocateRoom allocateroom = db.AllocateRooms.Find(id);
            db.AllocateRooms.Remove(allocateroom);
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
