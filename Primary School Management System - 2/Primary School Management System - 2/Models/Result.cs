using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.Models
{
    public class Result
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int ExamTypeID { get; set; }
        [Range(minimum:0,maximum:100,ErrorMessage = "Number Must be between 0-100")]
        public float? Number { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ExamType ExamType { get; set; }
    }
}