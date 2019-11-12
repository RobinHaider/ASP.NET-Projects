using UniversityManagementSystemWebApp.Gateway;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Manager
{
    public class SaveResultManager
    {
        SaveResultGateWay saveResultGateWay = new SaveResultGateWay();

        public void UpdateResult(SaveResult result)
        {
            saveResultGateWay.UpdateResult(result);
            return;
        }
    }
}