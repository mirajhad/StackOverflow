using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace StackOverflow.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/jquery-3.7.1.js", "~/Scripts/umd/popper.js", "~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Styles/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Styles/site").Include("~/Content/Styles.css"));

            //bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
            //    "~/Scripts/bootstrap.min.js",
            //    "~/Scripts/respond.min.js"));

            //bundles.Add(new StyleBundle("~/Styles/bootstrap").Include(
            //            "~/Content/bootstrap.min.css",
            //            "~/Content/site.css"));
            BundleTable.EnableOptimizations = true;
        }

    }
}
