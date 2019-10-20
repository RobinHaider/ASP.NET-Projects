using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Primary_School_Management_System___2.View_Model
{
    public class ResultVM
    {
        public string Class { get; set; }
        public string ExamType { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        [Display(Name = "বাংলা")]
        public int Bangla { get; set; }
        [Display(Name = "ইংরেজি")]
        public int English { get; set; }
        [Display(Name = "প্রাথমিক গণিত")]
        public int Math { get; set; }
        [Display(Name = "প্রাথমিক বিজ্ঞান")]
        public int GeneralScience { get; set; }
        [Display(Name = "বাংলাদেশ ও বিশ্বপরিচয়")]
        public int SocialScience { get; set; }
        [Display(Name = "ইসলাম ও নৈতিক শিক্ষা")]
        public int IslamicEdication { get; set; }
        [Display(Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা")]
        public int HinduismEducation { get; set; }
        [Display(Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা")]
        public int BuddhismEducation { get; set; }
        [Display(Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা")]
        public int ChristianityEducation { get; set; }

    }
}