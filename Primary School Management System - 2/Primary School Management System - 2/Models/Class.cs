﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.Models
{
    public class Class
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}