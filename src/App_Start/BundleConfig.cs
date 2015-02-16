using System.Web;
using System.Web.Optimization;

namespace SPASampleApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/base").Include(
                       "~/Content/Base.css",
                       "~/Content/DefaultTheme.css",
                       "~/Content/bootstrap.css",
                       "~/Content/bootstrap.min.css"
                       ));
        }
    }
}
