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
        }
    }
}
