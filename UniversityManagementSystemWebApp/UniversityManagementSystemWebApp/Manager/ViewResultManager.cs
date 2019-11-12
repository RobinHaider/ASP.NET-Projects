using System.Collections.Generic;
using UniversityManagementSystemWebApp.Gateway;
using UniversityManagementSystemWebApp.Models;
using UniversityManagementSystemWebApp.Models.ViewModel;

namespace UniversityManagementSystemWebApp.Manager
{
    public class ViewResultManager
    {
        ViewResultGateway viewResultGateway = new ViewResultGateway();

        public RegisterStudent StudentInfoByStdIdViewResult(int studentId)
        {
            return viewResultGateway.StudentInfoByStdIdViewResult(studentId);
        }

        public List<ViewResultVM> GetResultByStdId(int studentId)
        {
            return viewResultGateway.GetResultByStdId(studentId);
        }
    }
}