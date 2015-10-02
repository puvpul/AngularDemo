﻿using System.Web;
using System.Web.Optimization;

namespace TaskSchedule
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

            bundles.Add(new ScriptBundle("~/bundles/taskapp/style").Include
                ("~/Content/bootstrap.css",
                "~/Content/app.css"));
            bundles.Add(new ScriptBundle("~/bundles/taskapp/script").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-mocks.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                 "~/app/taskResourceMock.js",
                "~/app/taskApp.js",
                "~/app/dataService.js",
               "~/app/taskResource.js",
                "~/app/taskController.js",
                "~/app/editTaskController"
                ));
        }
    }
}