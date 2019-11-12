using System.Collections.Generic;
using UniversityManagementSystemWebApp.Gateway;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Manager
{
    public class ViewScheduleManger
    {
        ViewScheduleGateway viewScheduleGateway = new ViewScheduleGateway();

        public List<ViewScheduleVM> GetCourseScheduleInfoByDepId(int departmentId)
        {
            List<ViewScheduleVM> viewScheduleVms = viewScheduleGateway.GetCourseScheduleInfoByDepId(departmentId);

            if (viewScheduleVms != null)
            {
                foreach (ViewScheduleVM v in viewScheduleVms)
                {
                    v.RoomsInfo = GetRoomsInfo(v.Id);
                }
            }


            return viewScheduleVms;
        }

        public string GetRoomsInfo(int courseId)
        {
            List<RoomInfoVM> roomInfoVms = viewScheduleGateway.GetRoomListByCourseId(courseId);

            string roomInfo = "";

            if (roomInfoVms != null)
            {
                foreach (RoomInfoVM r in roomInfoVms)
                {
                    roomInfo += "RoomNo: " + r.RoomNo + ", " + r.Day + " " + r.From.ToShortTimeString() + " - " + r.To.ToShortTimeString() + "<br/>";
                }

                return roomInfo;
            }

            roomInfo = "Not Scheduled Yet";
            return roomInfo;

        }
    }
}