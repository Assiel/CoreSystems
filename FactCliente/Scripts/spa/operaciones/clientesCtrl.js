(function (app) {
    'use strict';

    app.controller('clientesCtrl', clientesCtrl);

    clientesCtrl.$inject = ['$scope', '$rootScope', '$location', 'apiService'];

    function clientesCtrl($scope, $rootScope, $location, apiService) {
        $scope.clientes = {};
        $scope.mostrarFacturas = mostrarFacturas;

        function mostrarFacturas(IdCli) {
            $rootScope.IdCli = IdCli;
            $location.path('/facturas');
        }

        function getClientes() {
            
            apiService.get(
                'api/operaciones/Clientes/',
                null,
                FactSuccess,
                FactError);
        }

        function FactSuccess(response) {
            $scope.clientes = response.data;
        }

        function FactError(response) {
            alert("Hubo un error al obtener el detalle de las facturas");
        }

        getClientes();
    }
})(angular.module("CoreSystems"));