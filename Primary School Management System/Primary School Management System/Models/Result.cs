using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System.Models
{
    public class Result
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public int? Number { get; set; }
        public int? ExamType { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}