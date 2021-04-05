using System.Web;
using System.Web.Optimization;

namespace MyFood
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/datatables/datatables.bootstrap.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //Create bundel for jQueryUI  
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Scripts/jquery-ui-{version}.js"));
            //css  
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include(
                   "~/Content/jquery-ui.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //bundles.Add(new ScriptBundle("~/bundles/js").Include(
            //          "~/Scripts/js/soft-design-system.js",
            //          "~/Scripts/js/soft-design-system.min.js",
            //          "~/Scripts/js/core/popper.min.js",
            //          "~/Scripts/js/plugins/choices.min.js",
            //          "~/Scripts/js/plugins/countup.min.js",
            //          "~/Scripts/js/plugins/flatpickr.min.js",
            //          "~/Scripts/js/plugins/moment.min.js",
            //          "~/Scripts/js/plugins/parallax.min.js",
            //          "~/Scripts/js/plugins/perfect-scrollbar.min.js",
            //          "~/Scripts/js/plugins/prism.min.js",
            //          "~/Scripts/js/plugins/rellax.min.js",
            //          "~/Scripts/js/plugins/tilt.min.js",
            //          "~/Scripts/js/plugins/typedjs.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Customize.css",
                      "~/Content/datatables/css/datatables.bootstrap.css",

                      "~/Content/bootstrap-rtl/bootstrap.rtl.css",
                      "~/Content/bootstrap-rtl/bootstrap.rtl.full.css",
                      "~/Content/bootstrap-rtl/bootstrap.rtl.full.min.css",
                      "~/Content/bootstrap-rtl/bootstrap.rtl.min"
                      
                      //"~/Content/Tailwind/compiled-tailwind.css",
                      //"~/Content/Tailwind/compiled-tailwind.min.css",
                      //"~/Content/Tailwind/tailwind.css",
                      //"~/Content/Tailwind/tailwind.min.css",

                      //"~/Content/soft-design/nucleo-icons.css",
                      //"~/Content/soft-design/nucleo-svg.css",
                      //"~/Content/soft-design/soft-design-system.css",
                      //"~/Content/soft-design/soft-design-system.min.css"

                      ));

        }
    }
}
