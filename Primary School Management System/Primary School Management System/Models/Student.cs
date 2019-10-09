using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System.Models
{
    public class Student
    {
        public int ID { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int ClassID { get; set; }
        public string Address { get; set; }
        public string GuardianMobileNumber { get; set; }
        public string GuardingEmail { get; set; }

        public virtual Class Class { get; set; }
    }
}