(function () {
    'use strict';

    angular
        .module('CNSS-App')
        .controller('storagesListController', storagesListController)
    .controller('storagesAddController', storagesAddController)
.controller('storagesEditController', storagesEditController)
.controller('storagesDeleteController', storagesDeleteController)
    .controller('wsdlController', wsdlController)
    .controller('DatePickerController', DatePickerController)
    .controller('AutoCompleteCtrl', AutoCompleteCtrl);



    

    wsdlController.$inject = ['$scope','$http', '$routeParams', '$location'];
    function wsdlController($scope, $http) {
        alert('sdfd');
        var url = 'https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic';
        var method = 'GET';
        createCORSRequest();
        alert('sdfd');

    };
    function soapRequest(){
        var str = 'your SOAP request'; 
        function createCORSRequest(method, url) 
        { var xhr = new XMLHttpRequest();
        if ("withCredentials" in xhr) 
        { xhr.open(method, url, false); } 
        else if (typeof XDomainRequest !== "undefined") 
        {
            alert
            xhr = new XDomainRequest(); xhr.open(method, url);
        }
        else {
            console.log("CORS not supported");
        alert("CORS not supported"); xhr = null; } return xhr; } 
        var xhr = createCORSRequest("POST", "http://localhost:8080");
        if (!xhr)
        { console.log("XHR issue"); return; } 
        xhr.onload = function (){ var results = xhr.responseText; console.log(results); }
        xhr.setRequestHeader('Content-Type', 'text/xml'); xhr.send(str);
    }
    function GetSoapResponse() {
        var pl = new SOAPClientParameters();
        SOAPClient.invoke(url, "PobierzDateAktualnegoKatTerc", pl, true, GetSoapResponse_callBack);
    }
    function GetSoapResponse_callBack(r, soapResponse) {
        if (soapResponse.xml)    // IE
            alert(soapResponse.xml);
        else    // MOZ
            alert((new XMLSerializer()).serializeToString(soapResponse));
    }

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
        //getCities($scope);
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
            $scope.storage.$remove({ id: $routeParams.id }, function () {
                $location.path('/');
            },
            function (error) {
                alert(error);
                $location.path('/');
            });
        };
    }
    DatePickerController.$inject = ['$scope'];
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
    AutoCompleteCtrl.$inject = ['$http', '$timeout', '$q', '$log'];
    function AutoCompleteCtrl($http, $timeout, $q, $log) {
        var self = this;
        self.simulateQuery = true;
        self.products = loadAllProducts($http);
        self.querySearch = querySearch;
        function querySearch(query) {
            var results = query ? self.products.filter(createFilterFor(query)) : self.products, deferred;
            if (self.simulateQuery) {
                deferred = $q.defer();
                $timeout(function () { deferred.resolve(results); }, Math.random() * 1000, false);
                return deferred.promise;
            } else {
                return results;
            }
        }
        function loadAllProducts($http) {
            var allProducts = [];
            var url = '';
            var result = [];
            url = 'api/Cities';
            $http({
                method: 'GET',
                url: url,
            }).then(function successCallback(response) {
                allProducts = response.data;
                angular.forEach(allProducts, function (product, key) {
                    result.push(
                        {
                            value: product.Name.toLowerCase(),
                            display: product.Name
                        });
                });
            }, function errorCallback(response) {
                console.log('Oops! Something went wrong while fetching the data. Status Code: ' + response.status + ' Status statusText: ' + response.statusText);
            });
            return result;
        }
        function createFilterFor(query) {
            var lowercaseQuery = angular.lowercase(query);
            return function filterFn(product) {
                return (product.value.indexOf(lowercaseQuery) === 0);
            };

        }
    }






})();