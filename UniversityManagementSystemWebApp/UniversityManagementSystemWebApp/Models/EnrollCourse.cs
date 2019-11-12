using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UniversityManagementSystemWebApp.Models
{
    public class EnrollCourse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Select RegNo")]
        [DisplayName("Student Reg. No.")]
        public int RegisterStudentId { get; set; }

        [NotMapped]
        public string Name { get; set; }
        [NotMapped]
        public string Email { get; set; }
        [NotMapped]
        public string Department { get; set; }

        [Required(ErrorMessage = "Please Select Course")]
        [DisplayName("Select Course")]
        [Remote("IsCourseAlreadyTakenByThisStd", "EnrollCourse", ErrorMessage = "Course Already Taken By This Student.", AdditionalFields = "RegisterStudentId")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please Select Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public virtual RegisterStudent RegisterStudent { get; set; }
        public virtual Course Course { get; set; }

    }
}