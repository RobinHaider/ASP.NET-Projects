using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class ViewScheduleGateway : Gateway
    {
        public List<ViewScheduleVM> GetCourseScheduleInfoByDepId(int departmentId)
        {
            Query = "SELECT Id,Code,Name FROM Courses WHERE DepartmentId=" + departmentId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<ViewScheduleVM> viewSchedule = null;
            if (Reader.HasRows)
            {
                viewSchedule = new List<ViewScheduleVM>();
                while (Reader.Read())
                {
                    ViewScheduleVM view = new ViewScheduleVM()
                    {
                        Id = Convert.ToInt32(Reader["Id"]),
                        CourseCode = Reader["Code"].ToString(),
                        Name = Reader["Name"].ToString(),
                    };
                    viewSchedule.Add(view);
                }
            }

            Reader.Close();
            Connection.Close();
            return viewSchedule;
        }

        public List<RoomInfoVM> GetRoomListByCourseId(int courseId)
        {
            Query = "SELECT C.CourseId, C.[From], C.[To], C.Name As RoomNo, D.Name AS Day" +
                    " FROM (SELECT AR.CourseId, AR.DayId, AR.[From], AR.[To], R.Name" +
                    " FROM AllocateRooms AR INNER JOIN Rooms R ON AR.RoomId=R.Id) AS C" +
                    " INNER JOIN Days D ON C.DayId=D.Id" +
                    " WHERE CourseId=" + courseId;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<RoomInfoVM> roomInfoVms = null;
            if (Reader.HasRows)
            {
                roomInfoVms = new List<RoomInfoVM>();
                while (Reader.Read())
                {
                    RoomInfoVM room = new RoomInfoVM()
                    {
                        RoomNo = Reader["RoomNo"].ToString(),
                        Day = Reader["Day"].ToString(),
                        From = Convert.ToDateTime(Reader["From"]),
                        To = Convert.ToDateTime(Reader["To"])
                    };
                    roomInfoVms.Add(room);
                }
            }



            Reader.Close();
            Connection.Close();
            return roomInfoVms;
        }

    }
}