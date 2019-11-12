
using System.ComponentModel;

namespace UniversityManagementSystemWebApp.Models
{
    public class Grade
    {
        public int Id { get; set; }

        [DisplayName("Grade")]
        public string Name { get; set; }
    }
}