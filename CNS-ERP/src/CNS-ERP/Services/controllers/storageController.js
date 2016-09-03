(function () {
    'use strict';

    angular
        .module('moviesApp')
        .controller('storageController', storageController);

    storageController.$inject = ['$scope', 'Storages'];

    function storageController($scope, Storages) {
        $scope.title = 'storageController';
        $scope.storages = Storages.query();

    }
})();
