using System.Collections.Generic;
using UniversityManagementSystemWebApp.Gateway;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Manager
{
    public class ViewCourseStaticsManager
    {
        ViewCourseStaticsGateway viewCourseStaticsGateway = new ViewCourseStaticsGateway();

        public List<ViewCourseStaticsVM> GetCourseStaticsByDepId(int departmentId)
        {
            return viewCourseStaticsGateway.GetCourseStaticsByDepId(departmentId);
        }
    }
}