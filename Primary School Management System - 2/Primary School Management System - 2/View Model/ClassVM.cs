using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.View_Model
{
    public class ClassVM
    {
        public int ID { get; set; }
        public string Class { get; set; }
        [Display(Name = "Class Teacher")]
        public string ClassTeacher { get; set; }
        public List<string> Subjects { get; set; }
        [Display(Name = "Total Student")]
        public int TotalStudent { get; set; }

    }
}