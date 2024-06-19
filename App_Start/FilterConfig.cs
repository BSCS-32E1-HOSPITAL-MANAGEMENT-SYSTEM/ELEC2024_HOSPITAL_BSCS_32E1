using System.Web;
using System.Web.Mvc;

namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
