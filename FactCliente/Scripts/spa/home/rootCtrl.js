(function (app) {
    'use strict';

    app.controller('rootCtrl', rootCtrl);

    rootCtrl.$inject = ['$scope', '$window', '$location', '$rootScope'];
    function rootCtrl($scope, $window, $location, membershipService, $rootScope, $mdSidenav, $anchorScroll) {
        $scope.thisYear = new Date().getFullYear();
        
    };

})(angular.module('CoreSystems'));

