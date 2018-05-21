(function (app) {
    'use strict';

    app.controller('facturasCtrl', facturasCtrl);

    facturasCtrl.$inject = ['$scope', '$rootScope', '$location', 'apiService'];

    function facturasCtrl($scope, $rootScope, $location, apiService) {
        
        $scope.facturas = {};

        $scope.mostrarDetalleFacturas = mostrarDetalleFacturas;

        function mostrarDetalleFacturas(FacturasId) {
            $rootScope.FacturaId=FacturasId;
            $location.path('/DetalleFactura');
        }

        function getFacturas(ClienteId) {

            if (ClienteId == undefined) {
                $location.path('/');
                return;
            }

            var config = {
                params: {
                    ClienteId: ClienteId
                }
            };
            apiService.get(
                'api/operaciones/Facturas/',
                config,
                FactSuccess,
                FactError);
        }

        function FactSuccess(response) {
            $scope.facturas = response.data;            
        }

        function FactError(response) {
            alert("Hubo un error al obtener las facturas");
        }

        getFacturas($rootScope.IdCli);
    }
})(angular.module("CoreSystems"));