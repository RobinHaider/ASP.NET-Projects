using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystemWebApp.Models
{
    public class Semister
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Please Select a Semister.")]
        [StringLength(10)]
        public string Name { get; set; }

    }
}