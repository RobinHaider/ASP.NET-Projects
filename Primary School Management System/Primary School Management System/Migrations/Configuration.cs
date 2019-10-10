using System.Collections.Generic;
using Primary_School_Management_System.Models;

namespace Primary_School_Management_System.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Primary_School_Management_System.DAL.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Primary_School_Management_System.DAL.SchoolDbContext context)
        {
            var students = new List<Student>
            {
                //class 5
                new Student(){ID = 1, RollNo = 1, Name = "Raihan Saikat", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 2,RollNo = 2, Name = "Abdul Ahad Limon", BirthDate = Convert.ToDateTime("2009-07-23"),FatherName = "Rafiqul Islam", MotherName = "Josna Ara Begum", ClassID = 5, Address = "Abdul-Hoque Bari, Shibpur", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 3, RollNo = 3, Name = "Abdul Samad Limon", BirthDate = Convert.ToDateTime("20-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 4, RollNo = 4, Name = "Sajid Ul Hoque", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 5, RollNo = 5, Name = "Pabel Islam", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //Class 4
                new Student(){ID = 6, RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 7, RollNo = 2, Name = "Raihan Saikat", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 8, RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 3
                new Student(){ID = 9, RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 10, RollNo = 2, Name = "Raihan Saikat", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 11, RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 2
                new Student(){ID = 12, RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 13, RollNo = 2, Name = "Raihan Saikat", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 14, RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 1
                new Student(){ID = 15, RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 16, RollNo = 2, Name = "Raihan Saikat", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 17, RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 0
                new Student(){ID = 18, RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 0, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 19, RollNo = 2, Name = "Raihan Saikat", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 0, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){ID = 20, RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = Convert.ToDateTime("2008-01-01"),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 0, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},
            };

            students.ForEach(s=>context.Students.AddOrUpdate(p=>p.ID,s));
            context.SaveChanges();

            //Teacher
            var teachers = new List<Teacher>()
            {
                new Teacher(){ID = 1, Name = "Riad Al Faisal", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 2, Name = "Faisal Hossain", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 3, Name = "Sabbir Mohammad Shakil", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 4, Name = "Ariful Hoque Rana", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 5, Name = "Mizanur Rahman", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 6, Name = "Nasib Al Farabi", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 7, Name = "Noyon Chowdhury", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ID = 8, Name = "Mostafa Raju", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"}
            };

            teachers.ForEach(s=>context.Teachers.AddOrUpdate(p=>p.ID,s));
            context.SaveChanges();

            //Class
            var classes = new List<Class>()
            {
                new Class(){ID = 0, ClassName = "Nursery", TeacherID = 6},
                new Class(){ID = 1, ClassName = "One", TeacherID = 5},
                new Class(){ID = 2, ClassName = "Two", TeacherID = 4},
                new Class(){ID = 3, ClassName = "Three", TeacherID = 3},
                new Class(){ID = 4, ClassName = "Four", TeacherID = 2},
                new Class(){ID = 5, ClassName = "Five", TeacherID = 1}
            };

            classes.ForEach(s=>context.Classes.AddOrUpdate(p=>p.ID,s));
            context.SaveChanges();

            //Subject
            var subjects = new List<Subject>()
            {
                //class 1
                new Subject(){ID = 1, Name = "আমার বাংলা বই", ClassID = 1, TeacherID = 1},
                new Subject(){ID = 2, Name = "English For Today", ClassID = 1, TeacherID = 2},
                new Subject(){ID = 3, Name = "প্রাথমিক গণিত", ClassID = 2, TeacherID = 3},

                //class 2
                new Subject(){ID = 4, Name = "আমার বাংলা বই", ClassID = 2, TeacherID = 4},
                new Subject(){ID = 5, Name = "প্রাথমিক গণিত", ClassID = 2, TeacherID = 5},
                new Subject(){ID = 6, Name = "English For Today", ClassID = 2, TeacherID = 6},

                //class 3
                new Subject(){ID = 7, Name = "আমার বাংলা বই", ClassID = 4, TeacherID = 7},
                new Subject(){ID = 8, Name = "প্রাথমিক গণিত", ClassID = 4, TeacherID = 8},
                new Subject(){ID = 9, Name = "English For Today", ClassID = 4, TeacherID = 1},
                new Subject(){ID = 10, Name = "প্রাথমিক বিজ্ঞান", ClassID = 4, TeacherID = 2},
                new Subject(){ID = 11, Name = "বাংলাদেশ ও বিশ্বপরিচয়", ClassID = 4, TeacherID = 3},
                new Subject(){ID = 12, Name = "ইসলাম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 4},
                new Subject(){ID = 13, Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 5},
                new Subject(){ID = 14, Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 6},
                new Subject(){ID = 15, Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 7},

                //class 4
                new Subject(){ID = 16, Name = "আমার বাংলা বই", ClassID = 4, TeacherID = 8},
                new Subject(){ID = 17, Name = "প্রাথমিক গণিত", ClassID = 4, TeacherID = 1},
                new Subject(){ID = 18, Name = "English For Today", ClassID = 4, TeacherID = 2},
                new Subject(){ID = 19, Name = "প্রাথমিক বিজ্ঞান", ClassID = 4, TeacherID = 3},
                new Subject(){ID = 20, Name = "বাংলাদেশ ও বিশ্বপরিচয়", ClassID = 4, TeacherID = 4},
                new Subject(){ID = 21, Name = "ইসলাম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 5},
                new Subject(){ID = 22, Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 6},
                new Subject(){ID = 23, Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 7},
                new Subject(){ID = 24, Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 8}, 

                //class 5
                new Subject(){ID = 25, Name = "আমার বাংলা বই", ClassID = 4, TeacherID = 1},
                new Subject(){ID = 26, Name = "প্রাথমিক গণিত", ClassID = 4, TeacherID = 2},
                new Subject(){ID = 27, Name = "English For Today", ClassID = 4, TeacherID = 3},
                new Subject(){ID = 28, Name = "প্রাথমিক বিজ্ঞান", ClassID = 4, TeacherID = 4},
                new Subject(){ID = 29, Name = "বাংলাদেশ ও বিশ্বপরিচয়", ClassID = 4, TeacherID = 5},
                new Subject(){ID = 30, Name = "ইসলাম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 6},
                new Subject(){ID = 31, Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 7},
                new Subject(){ID = 32, Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 8},
                new Subject(){ID = 33, Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 1},

                //class 0
                new Subject(){ID = 34, Name = "বাংলা", ClassID = 0, TeacherID = 2},
                new Subject(){ID = 35, Name = "English", ClassID = 0, TeacherID = 3},
                new Subject(){ID = 36, Name = "গণিত", ClassID = 0, TeacherID = 4}
            };

            subjects.ForEach(s=>context.Subjects.AddOrUpdate(p=>p.ID,s));
            context.SaveChanges();
        }
    }
}
