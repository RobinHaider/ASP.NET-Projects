using System.Web;
using System.Web.Mvc;

namespace Primary_School_Management_System___2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
