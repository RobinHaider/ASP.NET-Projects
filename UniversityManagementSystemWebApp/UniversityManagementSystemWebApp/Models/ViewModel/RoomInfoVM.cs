
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystemWebApp.Models.ViewModel
{
    public class RoomInfoVM
    {
        public string RoomNo { get; set; }
        public string Day { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime From { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime To { get; set; }

    }
}