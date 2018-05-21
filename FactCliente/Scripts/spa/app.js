(function () {
    'use strict';
    angular.module('CoreSystems', ['common.core'])
       .config(config);

    function config($routeProvider, $compileProvider, $locationProvider) {


        $compileProvider.debugInfoEnabled(false);
        $routeProvider
            .when("/", {
                templateUrl: "scripts/spa/home/index.html",
                controller: "indexCtrl"
            })
        .when("/facturas", {
            templateUrl: "scripts/spa/operaciones/facturas.html",
            controller: "facturasCtrl"
        })
         .when("/DetalleFactura", {
             templateUrl: "scripts/spa/operaciones/detalleFacturas.html",
             controller: "detalleFacturasCtrl"
         })
        .when("/Clientes", {
            templateUrl: "scripts/spa/operaciones/clientes.html",
            controller: "clientesCtrl"
        })


            .otherwise({ redirectTo: "/" });

    }
}
)();
