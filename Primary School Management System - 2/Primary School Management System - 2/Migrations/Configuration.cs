using System.Collections.Generic;
using Primary_School_Management_System___2.Models;

namespace Primary_School_Management_System___2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Primary_School_Management_System___2.DAL.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Primary_School_Management_System___2.DAL.SchoolDbContext context)
        {
            //Students
            var students = new List<Student>
            {
                //class 5
                new Student(){RollNo = 1, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 2, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Rafiqul Islam", MotherName = "Josna Ara Begum", ClassID = 5, Address = "Abdul-Hoque Bari, Shibpur", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 3, Name = "Abdul Samad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 4, Name = "Sajid Ul Hoque", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 5, Name = "Pabel Islam", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //Class 4
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 3
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 2
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                //class 1
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com"},


            };

            foreach (var student in students)
            {
                var studentInDatabase = context.Students.FirstOrDefault(s => s.ClassID == student.ClassID && s.RollNo == student.RollNo);
                if (studentInDatabase == null)
                {
                    context.Students.Add(student);
                }
            }

            //Class
            var classes = new List<Class>()
            {
                new Class(){ClassName = "One"},
                new Class(){ClassName = "Two"},
                new Class(){ClassName = "Three"},
                new Class(){ClassName = "Four"},
                new Class(){ClassName = "Five"}
            };

            classes.ForEach(s => context.Classes.AddOrUpdate(p => p.ClassName, s));
            context.SaveChanges();

            //Teacher
            var teachers = new List<Teacher>()
            {
                new Teacher(){Name = "Riad Al Faisal", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){Name = "Faisal Hossain", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){Name = "Sabbir Mohammad Shakil", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){Name = "Ariful Hoque Rana", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){Name = "Mizanur Rahman", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){ Name = "Nasib Al Farabi", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){Name = "Noyon Chowdhury", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"},
                new Teacher(){Name = "Mostafa Raju", Email = "robinhaider69@gmail.com", MobileNumber = "01831541161", Address = "Chowdhory Para, College Road, Sitakund", NID = "12345678912345678"}
            };

            teachers.ForEach(s => context.Teachers.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            //Subject
            var subjects = new List<Subject>()
            {
                //class 1
                new Subject(){Name = "আমার বাংলা বই", ClassID = 1, TeacherID = 1},
                new Subject(){Name = "English For Today", ClassID = 1, TeacherID = 2},
                new Subject(){Name = "প্রাথমিক গণিত", ClassID = 1, TeacherID = 3},

                //class 2
                new Subject(){Name = "আমার বাংলা বই", ClassID = 2, TeacherID = 4},
                new Subject(){Name = "প্রাথমিক গণিত", ClassID = 2, TeacherID = 5},
                new Subject(){Name = "English For Today", ClassID = 2, TeacherID = 6},

                //class 3
                new Subject(){Name = "আমার বাংলা বই", ClassID = 3, TeacherID = 7},
                new Subject(){Name = "প্রাথমিক গণিত", ClassID = 3, TeacherID = 8},
                new Subject(){Name = "English For Today", ClassID = 3, TeacherID = 1},
                new Subject(){Name = "প্রাথমিক বিজ্ঞান", ClassID = 4, TeacherID = 2},
                new Subject(){Name = "বাংলাদেশ ও বিশ্বপরিচয়", ClassID = 3, TeacherID = 3},
                new Subject(){Name = "ইসলাম ও নৈতিক শিক্ষা", ClassID = 3, TeacherID = 4},
                new Subject(){Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা", ClassID = 3, TeacherID = 5},
                new Subject(){Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা", ClassID = 3, TeacherID = 6},
                new Subject(){Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা", ClassID = 3, TeacherID = 7},

                //class 4
                new Subject(){Name = "আমার বাংলা বই", ClassID = 4, TeacherID = 8},
                new Subject(){Name = "প্রাথমিক গণিত", ClassID = 4, TeacherID = 1},
                new Subject(){Name = "English For Today", ClassID = 4, TeacherID = 2},
                new Subject(){Name = "প্রাথমিক বিজ্ঞান", ClassID = 4, TeacherID = 3},
                new Subject(){Name = "বাংলাদেশ ও বিশ্বপরিচয়", ClassID = 4, TeacherID = 4},
                new Subject(){Name = "ইসলাম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 5},
                new Subject(){Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 6},
                new Subject(){Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 7},
                new Subject(){ID = 24, Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা", ClassID = 4, TeacherID = 8}, 

                //class 5
                new Subject(){Name = "আমার বাংলা বই", ClassID = 5, TeacherID = 1},
                new Subject(){Name = "প্রাথমিক গণিত", ClassID = 5, TeacherID = 2},
                new Subject(){Name = "English For Today", ClassID = 5, TeacherID = 3},
                new Subject(){Name = "প্রাথমিক বিজ্ঞান", ClassID = 5, TeacherID = 4},
                new Subject(){Name = "বাংলাদেশ ও বিশ্বপরিচয়", ClassID = 5, TeacherID = 5},
                new Subject(){Name = "ইসলাম ও নৈতিক শিক্ষা", ClassID = 5, TeacherID = 6},
                new Subject(){Name = "হিন্দুধর্ম ও নৈতিক শিক্ষা", ClassID = 5, TeacherID = 7},
                new Subject(){Name = "বৌদ্ধধর্ম ও নৈতিক শিক্ষা", ClassID = 5, TeacherID = 8},
                new Subject(){Name = "খ্রিষ্টধর্ম ও নৈতিক শিক্ষা", ClassID = 5, TeacherID = 1},


            };

            foreach (var subject in subjects)
            {
                var subjectInDatabase = context.Subjects.FirstOrDefault(s => s.ClassID == subject.ClassID && s.Name == subject.Name);
                if (subjectInDatabase == null)
                {
                    context.Subjects.Add(subject);
                }
            }
            context.SaveChanges();
        }
    }
}
