using System.Web;
using System.Web.Optimization;

namespace OnLineStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/ControlPanel/css").Include(
                      "~/bower_components/bootstrap/dist/css/bootstrap.css",
                      "~/bower_components/font-awesome/css/font-awesome.css",
                      "~/bower_components/Ionicons/css/ionicons.css",
                      "~/dist/css/AdminLTE.css",
                      "~/dist/css/skins/_all-skins.css",
                      "~/bower_components/morris.js/morris.css",
                      "~/bower_components/jvectormap/jquery-jvectormap.css",
                      "~/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.css",
                      "~/bower_components/bootstrap-daterangepicker/daterangepicker.css" ,
                      "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.css"));



            bundles.Add(new ScriptBundle("~/ControlPanel/JS").Include(
                
          "~/bower_components/jquery/dist/jquery.js",
          "~/bower_components/jquery-ui/jquery-ui.js",
          "~/bower_components/bootstrap/dist/js/bootstrap.js",
          "~/bower_components/raphael/raphael.js",
          "~/bower_components/morris.js/morris.js",
          "~/bower_components/jquery-sparkline/dist/jquery.sparkline.js",
          "~/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
          "~/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
          "~/bower_components/jquery-knob/js/jquery.knob.js",
          "~/bower_components/moment/moment.js",
          "~/bower_components/bootstrap-daterangepicker/daterangepicker.js",
          "~/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.js",
          "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.js",
          "~/bower_components/jquery-slimscroll/jquery.slimscroll.js",
          "~/bower_components/fastclick/lib/fastclick.js",
          "~/dist/js/adminlte.js",
          "~/dist/js/pages/dashboard.js",
          "~/dist/js/demo.js"

          ));



        }
    }
}
