
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UniversityManagementSystemWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Code Must have 5-30 character")]
        [Required(ErrorMessage = "Please Enter Course Code")]
        [Column(TypeName = "varchar")]
        [Remote("IsCodeExist", "CourseValidation", ErrorMessage = "Course Code Already Exist.")]
        public string Code { get; set; }


        [Required(ErrorMessage = "Please Enter Course Name")]
        [Column(TypeName = "varchar")]
        [Remote("IsNameExist", "CourseValidation", ErrorMessage = "Course Code Already Exist.")]
        [StringLength(100, ErrorMessage = "Code Must have 5-30 character")]
        public string Name { get; set; }


        [Range(0.5, 5.0, ErrorMessage = "Credit Must be From 0.5-5")]
        [Required(ErrorMessage = "Please Enter Course Credit")]
        public double Credit { get; set; }


        [Required(ErrorMessage = "Please Enter Course Description")]
        [Column(TypeName = "varchar")]
        [StringLength(300, ErrorMessage = "Code Must have 5-30 character")]
        public string Description { get; set; }

        [DisplayName("Department")]
        [Required(ErrorMessage = "Please Select a Department")]
        public int DepartmentId { get; set; }

        [DisplayName("Semister")]
        [Required(ErrorMessage = "Please Select a Semister")]
        public int SemisterId { get; set; }



        public virtual Department Department { get; set; }


        public virtual Semister Semister { get; set; }

    }
}