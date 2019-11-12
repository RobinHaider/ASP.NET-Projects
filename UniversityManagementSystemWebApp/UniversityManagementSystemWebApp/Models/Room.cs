using System.ComponentModel;

namespace UniversityManagementSystemWebApp.Models
{
    public class Room
    {
        public int Id { get; set; }

        [DisplayName("Room No.")]
        public string Name { get; set; }

    }
}