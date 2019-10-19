using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.Models
{
    public class Class
    {
        public int ID { get; set; }
        [Display(Name = "Class")]
        public string ClassName { get; set; }
        [ForeignKey("Teacher")]
        public int? TeacherID { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}