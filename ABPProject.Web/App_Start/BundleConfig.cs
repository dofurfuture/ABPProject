﻿using System.Web.Optimization;

namespace ABPProject.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            bundles.Add(
                new StyleBundle("~/Bundles/vendor/css")
                    .Include("~/Content/toastr.min.css", new CssRewriteUrlTransform())
                    .Include("~/Scripts/sweetalert/sweet-alert.css", new CssRewriteUrlTransform())
                    .Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                );
            bundles.Add(
                new StyleBundle("~/Bundles/loginpage/css")
                    .Include("~/css/main.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/base/all.css", new CssRewriteUrlTransform())
                    .Include("~/Content/bootstrap-paper.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/toastr.min.css", new CssRewriteUrlTransform())
                    .Include("~/Scripts/sweetalert/sweet-alert.css", new CssRewriteUrlTransform())
                    .Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                );
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/top")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/modernizr-2.8.3.js"
                    )
                );
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/bottom")
                    .Include(
                        "~/Scripts/vue.js",
                        //"~/Scripts/iview.min.js",

                        "~/Scripts/json2.min.js",
                        "~/Content/js/jquery-1.10.2.min.js",
                        //"~/Scripts/jquery-2.2.0.min.js",
                        "~/Scripts/jquery-ui-1.11.4.min.js",
                        "~/Content/vendors/bootstrap/js/bootstrap.min.js",
                        "~/Scripts/moment-with-locales.min.js",
                        "~/Content/vendors/jquery-validate/jquery.validate.min.js",
                        "~/Scripts/messages_zh.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",
                        "~/Scripts/others/spinjs/spin.js",
                        "~/Scripts/others/spinjs/jquery.spin.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",

                        "~/Scripts/jquery.signalR-2.2.1.min.js",
                        "~/js/global.js"
                    )
                );

            //~/Bundles/css
            bundles.Add(
                new StyleBundle("~/Bundles/css")
                    .Include(
                    "~/Content/css/css1.css",
                    "~/Content/vendors/jquery-ui-1.10.4.custom/css/ui-lightness/jquery-ui-1.10.4.custom.min.css",
                    "~/Content/vendors/bootstrap/css/bootstrap.min.css",
                    "~/Content/vendors/intro.js/introjs.css",
                    "~/Content/vendors/calendar/zabuto_calendar.min.css",
                    "~/Content/vendors/sco.message/sco.message.css",
                    //"~/Content/vendors/intro.js/introjs.css",
                    "~/Content/vendors/animate.css/animate.css",
                    //"~/Content/vendors/jquery-pace/pace.css",
                    "~/Content/vendors/iCheck/skins/all.css",
                    "~/Content/vendors/jquery-notific8/jquery.notific8.min.css",
                    "~/Content/vendors/bootstrap-datepicker/css/bootstrap-datepicker.min.css",
                    "~/Content/vendors/bootstrap-daterangepicker/daterangepicker-bs3.css",
                    "~/Content/vendors/bootstrap-switch/css/bootstrap-switch.css",
                    //"~/css/iview.css",
                    "~/css/main-custom.css"
                    )
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/js")
                    .Include(
                    "~/js/main.js",
                    //"~/Content/js/jquery-1.10.2.min.js",
                    "~/Content/js/jquery-migrate-1.2.1.min.js",
                    "~/Content/vendors/bootstrap-hover-dropdown/bootstrap-hover-dropdown.js",
                    "~/Content/vendors/metisMenu/jquery.metisMenu.js",
                    "~/Content/vendors/slimScroll/jquery.slimscroll.js",
                    "~/Content/vendors/jquery-cookie/jquery.cookie.js",
                    "~/Content/vendors/jquery-notific8/jquery.notific8.min.js",
                    "~/Content/vendors/jquery-highcharts/highcharts.js",
                    "~/Content/js/jquery.menu.js",
                    //"~/Content/vendors/jquery-pace/pace.min.js",
                    "~/Content/vendors/holder/holder.js",
                    //"~/Content/vendors/responsive-tabs/responsive-tabs.js",
                    "~/Content/vendors/jquery-news-ticker/jquery.newsTicker.min.js",
                    "~/Content/vendors/moment/moment.js",
                    "~/Content/vendors/bootstrap-datepicker/js/bootstrap-datepicker.js",
                    "~/Content/vendors/bootstrap-datepicker/js/bootstrap-datepicker.zh-CN.min.js",
                    "~/Content/vendors/bootstrap-switch/js/bootstrap-switch.min.js",

                    "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.js",
                    "~/Content/js/main.js",
                    "~/Content/vendors/intro.js/intro.js",
                    "~/Content/vendors/flot-chart/jquery.flot.js",
                    "~/Content/vendors/calendar/zabuto_calendar.min.js",
                    "~/Content/vendors/sco.message/sco.message.js"
                    )
                );
            bundles.Add(
                new ScriptBundle("~/Table/js")
                    .Include(
                    "~/Content/js/ui-tabs.js",
                    "~/Scripts/bootstrap-table.min.js",
                    "~/Scripts/tableExport.js",
                    "~/Scripts/bootstrap-editable.js",
                    "~/Scripts/bootstrap-table-editable.js",
                    "~/Scripts/bootstrap-table-export.js",
                    "~/Scripts/bootstrap-table-zh-CN.js"
                    )
            );

            bundles.Add(
                new StyleBundle("~/Table/css")
                    .Include(
                    "~/Content/bootstrap-table.min.css"
                    )
            );

            bundles.Add(
                new StyleBundle("~/Product/css")
                .Include(
                "~/css/base.css",
                "~/css/common.css",
                "~/css/font-awesome/4.5.0/css/font-awesome.min.css",
                "~/css/layer/mobile/need/layer.css",
                "~/css/layui/css/layui.css",
                "~/css/orange.css",
                "~/Views/Product/index.css"
                )
            );

            bundles.Add(
                new ScriptBundle("~/Product/js")
                .Include(
                "~/js/jquery-1.10.2.min.js",
                "~/js/jquery.slimscroll.js",
                "~/css//layer/layer.js",
                "~/css/layui/layui.js",
                "~/js/common.js",
                "~/Views/Product/index.js"
                )
            );

            bundles.Add(
                new StyleBundle("~/Home/css")
                .Include(
                "~/css/base.css",
                "~/css/font-awesome/4.5.0/css/font-awesome.min.css",
                "~/css/owl.carousel.css",
                "~/css/owl.theme.css",
                "~/Views/Home/index.css"
                )
            );

            bundles.Add(
                new ScriptBundle("~/Home/js")
                .Include(
                "~/js/jquery.min.js",
                "~/js/owl.carousel.js",
                "~/Views/Home/index.js"
                )
            );

            bundles.Add(
                new StyleBundle("~/Detail/css").
                Include(
                "~/css/swiper.min.css",
                "~/Views/Detail/index.css"
                )
            );

            bundles.Add(
                new ScriptBundle("~/Detail/js").Include(
                "~/js/swiper.min.js",
                "~/Views/Detail/index.js"
                )
            );
        }
    }
}