using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClassID { get; set; }
        public int? TeacherID { get; set; }

        public virtual Class Class { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}