using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class ViewCourseStaticsGateway : Gateway
    {
        public List<ViewCourseStaticsVM> GetCourseStaticsByDepId(int departmentId)
        {
            Query = "SELECT cs.Code,cs.Name,cs.Semister,ISNULL(t.Name,'Not Assigned Yet') AS AssignedTo FROM " +
                    "(SELECT c.Id,C.Code,C.Teacher_Id, c.Name,c.DepartmentId,s.Name Semister " +
                    "FROM Courses c INNER JOIN Semisters s ON C.SemisterId=S.Id) cs " +
                    "LEFT JOIN Teachers t ON t.Id = cs.Teacher_Id " +
                    " WHERE cs.DepartmentId=" + departmentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<ViewCourseStaticsVM> viewCourseStatics = null;
            if (Reader.HasRows)
            {
                viewCourseStatics = new List<ViewCourseStaticsVM>();
                while (Reader.Read())
                {
                    ViewCourseStaticsVM view = new ViewCourseStaticsVM()
                    {
                        Code = Reader["Code"].ToString(),
                        Name = Reader["Name"].ToString(),
                        Semister = Reader["Semister"].ToString(),
                        AssignedTo = Reader["AssignedTo"].ToString()
                    };
                    viewCourseStatics.Add(view);
                }
            }

            Reader.Close();
            Connection.Close();
            return viewCourseStatics;
        }
    }
}