using System.Web;
using System.Web.Optimization;

namespace FactCliente
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/vendors/angular.js",
                "~/Scripts/vendors/angular-route.js",
                "~/Scripts/vendors/angular-validator.js",
                "~/Scripts/vendors/angular-messages.js",
                "~/Scripts/vendors/angular-local-storage.js",
                "~/Scripts/vendors/angular-cookies.js",
                "~/Scripts/vendors/angular-base64.js",
                "~/Scripts/vendors/angular-aria.js",
                "~/Scripts/vendors/angular-animate.js",
                "~/Scripts/vendors/angular-locale_es-ni.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                "~/Scripts/spa/modules/common.core.js",
                "~/Scripts/spa/modules/common.ui.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/home/rootCtrl.js",
                "~/Scripts/spa/home/indexCtrl.js",
                "~/Scripts/spa/services/apiService.js",
                "~/Scripts/spa/operaciones/facturasCtrl.js",
                "~/Scripts/spa/operaciones/detalleFacturasCtrl.js",
                "~/Scripts/spa/operaciones/clientesCtrl.js"
                )
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
