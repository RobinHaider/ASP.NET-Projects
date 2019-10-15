using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be more than 50 character")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First letter must be capital letter and alphabet only")]
        public string Name { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please inset the email in correct format")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Mobile Number must be 11 digits")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Address must be between 10 to 100 character")]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{17}$", ErrorMessage = "NID Number must be 17 digits")]
        public string NID { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual Class Class { get; set; }
    }
}