
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UniversityManagementSystemWebApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }


        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name Must have 5-100 character")]
        [Required(ErrorMessage = "Please Enter Teacher Name")]
        [Column(TypeName = "varchar")]
        //[Remote("IsNameExist", "TeacherValidation", ErrorMessage = "Name Already Exist.")]
        public string Name { get; set; }


        [StringLength(300, MinimumLength = 5, ErrorMessage = "Address Must have 5-300 character")]
        [Required(ErrorMessage = "Please Enter Address")]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }


        [StringLength(100, MinimumLength = 5, ErrorMessage = "Email Must have 5-100 character")]
        [Required(ErrorMessage = "Please Enter Your Email")]
        [Column(TypeName = "varchar")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter your Email in Standered Format")]
        [Remote("IsEmailExist", "TeacherValidation", ErrorMessage = "Email Already Exist.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Please Enter Your ContactNo")]
        [Column(TypeName = "varchar")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a number")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Not a valid Phone number")]
        [DisplayName("Contact No")]
        [StringLength(16, MinimumLength = 10, ErrorMessage = "ContactNo Must Be 10-16 Character.")]
        [Remote("IsContactNoExist", "TeacherValidation", ErrorMessage = "ContactNo Already Exist.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Select Designation")]
        [DisplayName("Designation")]
        public int DesignationId { get; set; }

        [Required(ErrorMessage = "Please Select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }


        [Required(ErrorMessage = "Please Enter Max Credit.")]
        [Range(0, 100.0, ErrorMessage = "Credit Must be From 0-100")]
        [DisplayName("Credti To Be Taken")]
        public double CreditToBeTaken { get; set; }


        public double RemainingCredit { get; set; }


        public virtual Designation Designation { get; set; }
        public virtual Department Department { get; set; }

        public virtual List<Course> Courses { get; set; }

    }
}