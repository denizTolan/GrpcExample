using System.Web;
using System.Web.Mvc;

namespace GrpcExample.Test.SF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
