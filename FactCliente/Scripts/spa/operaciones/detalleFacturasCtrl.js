(function (app) {
    'use strict';

    app.controller('detalleFacturasCtrl', detalleFacturasCtrl);

    detalleFacturasCtrl.$inject = ['$scope', '$rootScope','$location', 'apiService'];

    function detalleFacturasCtrl($scope, $rootScope,$location, apiService) {       
        $scope.detalleFacturas = {};

        function actionLink() {
            $location.path('/facturas');
        }

        function getDetalleFacturas(FacturaId) {

            if (FacturaId == undefined) {
                $location.path('/');
                return;
            }

            var config = {
                params: {
                    FacturasId: FacturaId
                }
            };
            apiService.get(
                'api/operaciones/DetalleFacturas/',
                config,
                FactSuccess,
                FactError);
        }

        function FactSuccess(response) {
            $scope.detalleFacturas = response.data;
        }

        function FactError(response) {
            alert("Hubo un error al obtener el detalle de las facturas");
        }

        getDetalleFacturas($rootScope.FacturaId);
    }
})(angular.module("CoreSystems"));