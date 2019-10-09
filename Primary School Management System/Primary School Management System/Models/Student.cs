using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [Range(1,300,ErrorMessage = "RollNo must be between 1 to 300")]
        public int RollNo { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Name cannot be more than 50 character")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First letter must be capital letter and alphabet only")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be more than 50 character")]
        [Display(Name = "Father's Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First letter must be capital letter and alphabet only")]
        public string FatherName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be more than 50 character")]
        [Display(Name = "Mother's Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First letter must be capital letter and alphabet only")]
        public string MotherName { get; set; }

        [Required]
        public int ClassID { get; set; }

        [Required]
        [StringLength(100,MinimumLength = 10,ErrorMessage = "Address must be between 10 to 100 character")]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{11}$",ErrorMessage = "Mobile Number must be 11 digits")]
        [Display(Name = "Guardian's Mobile Number")]
        public string GuardianMobileNumber { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please inset the email in correct format")]
        [Display(Name = "Guardian's Email")]
        public string GuardianEmail { get; set; }

        public virtual Class Class { get; set; }
    }
}