using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string NID { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual Class ClassTeacherOf { get; set; }
    }
}