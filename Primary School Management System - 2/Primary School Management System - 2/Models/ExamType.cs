using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.Models
{
    public class ExamType
    {
        public int ID { get; set; }
        [Display(Name = "Exam Type")]
        public string TypeName { get; set; }
    }
}