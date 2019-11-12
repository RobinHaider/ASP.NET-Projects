using System.Collections.Generic;
using UniversityManagementSystemWebApp.Gateway;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Manager
{
    public class EnrollCourseManager
    {
        EnrollCourseGateway enrollCourseGateway = new EnrollCourseGateway();
        public RegisterStudent StudentInfoByStdId(int studentId)
        {
            return enrollCourseGateway.StudentInfoByStdId(studentId);
        }

        public string GetDepartmentName(int departmentId)
        {
            return enrollCourseGateway.GetDepartmentName(departmentId);
        }

        public List<Course> GetCourseByDepId(int departmentId)
        {
            return enrollCourseGateway.GetCourseByDepId(departmentId);
        }

        public List<Course> EnrollCourseByStd(int studentId)
        {
            return enrollCourseGateway.EnrollCourseByStd(studentId);
        }
    }
}