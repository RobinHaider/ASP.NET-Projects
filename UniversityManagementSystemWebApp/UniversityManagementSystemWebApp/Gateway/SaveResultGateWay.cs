using System.Data.SqlClient;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class SaveResultGateWay : Gateway
    {
        public void UpdateResult(SaveResult result)
        {
            Query = "UPDATE SaveResults SET GradeId=" + result.GradeId + " WHERE Id =" + result.Id;

            Command = new SqlCommand() { Connection = Connection, CommandText = Query };

            Connection.Open();

            Command.ExecuteNonQuery();

            Connection.Close();

        }
    }
}