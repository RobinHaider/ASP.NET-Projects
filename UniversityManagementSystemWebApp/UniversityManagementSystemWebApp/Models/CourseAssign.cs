using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystemWebApp.Models
{
    public class CourseAssign
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Select Department.")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }


        [Required(ErrorMessage = "Please Select Teacher.")]
        [DisplayName("Teacher")]
        public int TeacherId { get; set; }

        [NotMapped]
        [DisplayName("Credit To Be Taken")]
        public double CreditToBeTaken { get; set; }

        [DisplayName("Reamining Credit")]
        [NotMapped]
        public double ReaminingCredit { get; set; }

        [Required(ErrorMessage = "Please Select Course.")]
        [DisplayName("Course")]
        public int CourseId { get; set; }


        [NotMapped]
        public string Name { get; set; }
        [NotMapped]
        public double Credit { get; set; }



        public virtual Department Department { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}