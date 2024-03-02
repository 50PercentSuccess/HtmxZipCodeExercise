using System.Web;
using System.Web.Optimization;

namespace HtmxZipCodeExercise
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/3rdParty/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/Scripts/3rdParty/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/htmx").Include(
                        "~/Content/Scripts/htmx.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                      
                      "~/Content/Scripts/site.css"));
        }
    }
}
