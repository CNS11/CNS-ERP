(function () {
    'use strict';

    angular
        .module('CNSS-App')
        .controller('storagesListController', storagesListController)
    .controller('storagesAddController', storagesAddController)
.controller('storagesEditController', storagesEditController)
.controller('storagesDeleteController', storagesDeleteController);

    storagesListController.$inject = ['$scope', 'Storages'];

    function storagesListController($scope, Storages) {
        $scope.Storages = Storages.query();
    }
    storagesAddController.$inject = ['$scope', '$location', 'Storages'];

    function storagesAddController($scope, $location, Storages) {

        $scope.storage = new Storages();
        $scope.add = function () {
            $scope.storage.$save(function () {
                $location.path('/');
            },
                        function (error) {
                            _showValidationErrors($scope, error);
                        }
            );
        };

    }

    /* Movies Edit Controller */
    storagesEditController.$inject = ['$scope', '$routeParams', '$location', 'Storages'];

    function storagesEditController($scope, $routeParams, $location, Storages) {
        $scope.storage = Storages.get({ id: $routeParams.id });
        getCities($scope);
        $scope.edit = function () {
            $scope.storage.$save(function () {
                
                $location.path('/');
            },
            function (error) {
           _showValidationErrors($scope, error);
                            });
        };
    }

    /* Movies Delete Controller  */
    storagesDeleteController.$inject = ['$scope', '$routeParams', '$location', 'Storages'];

    function storagesDeleteController($scope, $routeParams, $location, Storages) {
        $scope.storage = Storages.get({ id: $routeParams.id });
        $scope.remove = function () {
            $scope.storage.$remove(function () {
                $location.path('/');
            });
        };
    }
    function DatePickerController($scope) {
        $scope.open = function ($event) {
            $event.preventDefault();
            $event.stopPropagation();

            $scope.opened = true;
        };
    }
    function _showValidationErrors($scope, error) {
        $scope.validationErrors = [];
        if (error.data && angular.isObject(error.data)) {
            for (var key in error.data) {
                $scope.validationErrors.push(error.data[key][0]);
            }
        } else {
            $scope.validationErrors.push('Nie można było dodać magazynu.');
        };
    }
    function getCities($scope)
    {
        $http.get("https://uslugaterytws1.stat.gov.pl/TerytWs1.svc?singleWsdl")
     .then(function (response) {
         $scope.data = response.data;
     });

    }
})();