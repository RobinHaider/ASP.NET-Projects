using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Primary_School_Management_System___2.DAL;
using Primary_School_Management_System___2.View_Model;

namespace Primary_School_Management_System___2.Controllers
{
    public class ClassController : Controller
    {
        SchoolDbContext db = new SchoolDbContext();

        // GET: Class
        public ActionResult Index()
        {
            List<ClassVM> classVms = new List<ClassVM>();
            var classes = db.Classes
                .Include(s => s.Subjects)
                .Include(s => s.Teacher)
                .ToList();

            foreach (var @class in classes)
            {
                ClassVM classVm = new ClassVM();

                classVm.Class = @class.ClassName;
                classVm.ClassTeacher = @class.Teacher.Name;
                @classVm.Subjects = new List<string>();
                @class.Subjects.ForEach(s=> classVm.Subjects.Add(s.Name));
                classVm.TotalStudent = db.Students
                    .Count(s => s.ClassID == @class.ID);

                classVms.Add(classVm);
            }

            

            return View(classVms);
        }
    }
}