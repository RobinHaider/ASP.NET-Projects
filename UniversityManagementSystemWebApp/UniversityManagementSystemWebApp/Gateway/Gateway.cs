using System.Data.SqlClient;
using System.Web.Configuration;

namespace UniversityManagementSystemWebApp.Gateway
{
    public class Gateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["UniversityDbContext"].ConnectionString;
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}