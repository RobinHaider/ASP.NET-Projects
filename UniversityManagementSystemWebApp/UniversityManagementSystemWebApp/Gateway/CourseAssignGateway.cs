using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class CourseAssignGateway : Gateway
    {
        public List<Teacher> GetTeacherByDepartmentId(int departmentId)
        {
            Query = "SELECT * FROM Teachers WHERE DepartmentId=" + departmentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<Teacher> teachers = null;
            if (Reader.HasRows)
            {
                teachers = new List<Teacher>();
                while (Reader.Read())
                {
                    Teacher teacher = new Teacher()
                    {
                        Id = Convert.ToInt32(Reader["Id"]),
                        Name = Reader["Name"].ToString()
                    };

                    teachers.Add(teacher);
                }
            }

            Reader.Close();
            Connection.Close();
            return teachers;
        }

        public List<Course> GetCourseByDepartmentId(int departmentId)
        {
            Query = "SELECT * FROM Courses WHERE DepartmentId=" + departmentId + " AND Teacher_Id IS NULL";

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

        public Teacher GetRemainingCreditByTeacherId(int teacherId)
        {
            Query = "SELECT * FROM Teachers WHERE Id=" + teacherId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            Teacher teacher = null;
            while (Reader.Read())
            {
                teacher = new Teacher()
               {
                   CreditToBeTaken = Convert.ToDouble(Reader["CreditToBeTaken"]),
                   RemainingCredit = Convert.ToDouble(Reader["RemainingCredit"])
               };


            }


            Reader.Close();
            Connection.Close();
            return teacher;
        }

        public Course GetCourseInfoByCourseId(int courseId)
        {
            Query = "SELECT * FROM Courses WHERE Id=" + courseId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            Course course = null;
            while (Reader.Read())
            {
                course = new Course()
                {
                    Name = Reader["Name"].ToString(),
                    Credit = Convert.ToDouble(Reader["Credit"])
                };
            }


            Reader.Close();
            Connection.Close();
            return course;
        }


        //Assign Teacher To Course Table.....................
        public int AssignCourse(int teacherId, int courseId)
        {
            Query = "UPDATE Courses SET Teacher_Id = " + teacherId + " WHERE Id=" + courseId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();


            Connection.Close();

            return rowAffected;
        }

        //update Remaining Credit of Teacher  after assign course
        public int UpdateRemainingCreditOfTeacher(double remainingCredit, int teacherId)
        {
            Query = "UPDATE Teachers SET RemainingCredit = " + remainingCredit + " WHERE Id=" + teacherId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();


            Connection.Close();

            return rowAffected;
        }
    }
}