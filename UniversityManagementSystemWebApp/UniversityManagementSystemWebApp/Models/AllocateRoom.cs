using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace UniversityManagementSystemWebApp.Models
{
    public class AllocateRoom
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please Select Course")]
        [DisplayName("Course")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please Select Room")]
        [DisplayName("Room No.")]
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Please Select Day")]
        [DisplayName("Day")]
        public int DayId { get; set; }

        [Required(ErrorMessage = "Please Select Starting Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime From { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [Required(ErrorMessage = "Please Select End Time")]
        [Remote("IsRoomBusyAtThatTime", "AllocateRoom", HttpMethod = "Post", ErrorMessage = "Room Or Course Already Busy At That Time.", AdditionalFields = "CourseId,RoomId,DayId,From,To")]
        public DateTime To { get; set; }


        public virtual Department Department { get; set; }
        public virtual Course Course { get; set; }
        public virtual Room Room { get; set; }
        public virtual Day Day { get; set; }
    }
}