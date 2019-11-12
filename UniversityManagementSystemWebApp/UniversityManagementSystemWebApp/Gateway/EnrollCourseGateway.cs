using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class EnrollCourseGateway : Gateway
    {
        public RegisterStudent StudentInfoByStdId(int studentId)
        {
            Query = "SELECT * FROM RegisterStudents WHERE Id=" + studentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            RegisterStudent student = null;
            while (Reader.Read())
            {
                student = new RegisterStudent()
                {
                    Name = Reader["Name"].ToString(),
                    Email = Reader["Email"].ToString(),
                    DepartmentId = Convert.ToInt32(Reader["DepartmentId"])
                };


            }


            Reader.Close();
            Connection.Close();
            return student;
        }

        public string GetDepartmentName(int departmentId)
        {
            Query = "SELECT Name FROM Departments WHERE Id=" + departmentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            string department = null;
            while (Reader.Read())
            {

                department = Reader["Name"].ToString();
            }


            Reader.Close();
            Connection.Close();
            return department;
        }

        public List<Course> GetCourseByDepId(int departmentId)
        {
            Query = "SELECT * FROM Courses WHERE DepartmentId=" + departmentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<Course> courses = null;
            if (Reader.HasRows)
            {
                courses = new List<Course>();
                while (Reader.Read())
                {
                    Course course = new Course()
                    {
                        Id = Convert.ToInt32(Reader["Id"]),
                        Name = Reader["Name"].ToString()
                    };
                    courses.Add(course);
                }
            }

            Reader.Close();
            Connection.Close();
            return courses;
        }

        public List<Course> EnrollCourseByStd(int studentId)
        {
            Query = "SELECT C.Id As Id, C.Code As Code FROM EnrollCourses E INNER JOIN Courses C ON E.CourseId=C.Id WHERE RegisterStudentId=" + studentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<Course> courses = null;
            if (Reader.HasRows)
            {
                courses = new List<Course>();
                while (Reader.Read())
                {
                    Course course = new Course()
                    {
                        Id = Convert.ToInt32(Reader["Id"]),
                        Code = Reader["Code"].ToString()
                    };
                    courses.Add(course);
                }
            }

            Reader.Close();
            Connection.Close();
            return courses;
        }


    }
}