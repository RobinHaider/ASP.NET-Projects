using System.Collections.Generic;
using UniversityManagementSystemWebApp.Gateway;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Manager
{
    public class CourseAssignManager
    {
        CourseAssignGateway courseAssignGateway = new CourseAssignGateway();

        public List<Teacher> GetTeacherByDepartmentId(int departmentId)
        {
            return courseAssignGateway.GetTeacherByDepartmentId(departmentId);
        }

        //GetCourseByDepartmentId................
        public List<Course> GetCourseByDepartmentId(int departmentId)
        {
            return courseAssignGateway.GetCourseByDepartmentId(departmentId);
        }

        //GetRemainingCreditByTeacherId...........
        public Teacher GetRemainingCreditByTeacherId(int teacherId)
        {
            return courseAssignGateway.GetRemainingCreditByTeacherId(teacherId);
        }

        public Course GetCourseInfoByCourseId(int courseId)
        {
            return courseAssignGateway.GetCourseInfoByCourseId(courseId);
        }

        public string AssignCourse(CourseAssign courseassign)
        {
            int assignCourse = courseAssignGateway.AssignCourse(courseassign.TeacherId, courseassign.CourseId);

            if (assignCourse > 0)
            {
                double remainingCredit = courseassign.ReaminingCredit - courseassign.Credit;
                int updateRemainingCredit = courseAssignGateway.UpdateRemainingCreditOfTeacher(remainingCredit,
                    courseassign.TeacherId);

            }

            return "Course Assign Successfully.";
        }
    }
}