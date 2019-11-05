using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.View_Model
{
    public class StudentResultVM
    {
        public string Subject { get; set; }
        [Display(Name = "Half Yearly")]
        public float? HalfYearly { get; set; }
        public float? Final { get; set; }
    }
}