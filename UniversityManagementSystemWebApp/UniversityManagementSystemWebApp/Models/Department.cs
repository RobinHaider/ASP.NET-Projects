using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UniversityManagementSystemWebApp.Models
{
    public class Department
    {
        public int Id { get; set; }

        [StringLength(7, MinimumLength = 2, ErrorMessage = "Code Must be 2-7 character.")]
        [Required(ErrorMessage = "Please Enter Department Code")]
        [Column(TypeName = "varchar")]
        [Remote("IsCodeExist", "DepartmentValidation", ErrorMessage = "Department Code Already Exist.")]
        [DisplayName("Code")]
        public string Code { get; set; }


        [DisplayName("Name")]
        [Required(ErrorMessage = "Please Enter Department Name")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Department name must be 5-100 character.")]
        [Column(TypeName = "varchar")]
        [Remote("IsNameExist", "DepartmentValidation", ErrorMessage = "Department Name Already Exist.")]
        public string Name { get; set; }


        public virtual List<Course> Courses { get; set; }
        public virtual List<Teacher> Teachers { get; set; }

    }
}