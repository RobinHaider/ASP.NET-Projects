using System.ComponentModel;

namespace UniversityManagementSystemWebApp.Models
{
    public class Day
    {
        public int Id { get; set; }

        [DisplayName("Day")]
        public string Name { get; set; }
    }
}