
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystemWebApp.Models
{
    public class Designation
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100, ErrorMessage = "Maximum 100 character")]
        [DisplayName("Designtion")]
        public string Name { get; set; }
    }
}