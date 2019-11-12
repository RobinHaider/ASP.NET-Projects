using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystemWebApp.Models;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class ViewResultGateway : Gateway
    {
        public RegisterStudent StudentInfoByStdIdViewResult(int studentId)
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
                    DepartmentId = Convert.ToInt32(Reader["DepartmentId"]),
                    Id = Convert.ToInt32(Reader["Id"]),
                    Contact = Reader["Contact"].ToString(),
                    Address = Reader["Address"].ToString(),
                    RegistationNumber = Reader["RegistationNumber"].ToString()
                };


            }


            Reader.Close();
            Connection.Close();
            return student;
        }

        public List<ViewResultVM> GetResultByStdId(int studentId)
        {
            Query = "SELECT EC.CourseCode, EC.Name, EC.Credit,ISNULL(SR.Name,'Not Graded Yet')  AS Grade" +
                    " FROM (SELECT E.CourseId, C.Code AS CourseCode, C.Name, C.Credit FROM EnrollCourses E" +
                    " INNER JOIN Courses C ON E.CourseId=C.Id" +
                    " WHERE E.RegisterStudentId=" + studentId + ") EC" +
                    " LEFT JOIN" +
                    " (SELECT S.CourseId, G.Name  FROM SaveResults S" +
                    " INNER JOIN Grades G ON S.GradeId=G.Id" +
                    " WHERE RegisterStudentId =" + studentId + ") SR" +
                    " ON SR.CourseId=EC.CourseID";

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<ViewResultVM> viewResultVms = null;
            if (Reader.HasRows)
            {
                viewResultVms = new List<ViewResultVM>();
                while (Reader.Read())
                {
                    ViewResultVM veResultVm = new ViewResultVM()
                    {
                        CourseCode = Reader["CourseCode"].ToString(),
                        Name = Reader["Name"].ToString(),
                        Credit = Convert.ToDouble(Reader["Credit"]),
                        Grade = Reader["Grade"].ToString()
                    };
                    viewResultVms.Add(veResultVm);
                }
            }

            Reader.Close();
            Connection.Close();
            return viewResultVms;
        }
    }
}