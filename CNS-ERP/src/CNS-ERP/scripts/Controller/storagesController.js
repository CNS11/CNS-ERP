(function () {
    'use strict';

    angular
        .module('CNSS-App')
        .controller('storagesListController', storagesListController)
    .controller('storagesAddController', storagesAddController)
.controller('storagesEditController', storagesEditController)
.controller('storagesDeleteController', storagesDeleteController)
    .controller('wsdlController', wsdlController)
    .controller('DatePickerController', DatePickerController);



    

    wsdlController.$inject = ['$scope','$http', '$routeParams', '$location'];
    function wsdlController($scope, $http) {
        alert('sdfd');
        var url = 'https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic';
        var method = 'GET';
        createCORSRequest();
        alert('sdfd');
   //     GetSoapResponse();
       
        //GetSoapResponse();
        //var createCORSRequest = function (method, url) {
        //    var xhr = new XMLHttpRequest();
        //    if ("withCredentials" in xhr) {
        //        // Most browsers.
        //        xhr.open(method, url, true);
        //    } else if (typeof XDomainRequest != "undefined") {
        //        // IE8 & IE9
        //        xhr = new XDomainRequest();
        //        xhr.open(method, url);
        //    } else {
        //        // CORS not supported.
        //        xhr = null;
        //    }
        //    return xhr;
        //};

        //var url = 'https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic';
        //var method = 'GET';
        //var xhr = createCORSRequest(method, url);

        //xhr.onload = function () {
        //    // Success code goes here.
        //};

        //xhr.onerror = function () {
        //    // Error code goes here.
        //};


        //xhr.withCredentials = true;
        //xhr.setRequestHeader('Access-Control-Allow-Origin', '<origin> | *');
        //xhr.send();

        //$http.get('https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic').success(function (response) {
        //    $scope.listCities = response;
        //}).error(function () {
        //    alert('sdfdf');
        //});
        //$.ajax({
        //    type: "GET",
        //    url: "https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic",
        //    data: "{}",
        //    dataType: "xml",
        //    contentType: "application/xml; charset=utf-8",
        //    success: function (data) {
        //        alert(data);
        //    },
        //    complete: function (data) {
        //        alert(data);
        //    },
        //    error: function (data) {
        //        alert(data);
        //    }
        //});

        //var url = 'https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic';
        //var xhr=createCORSRequest('GET', url);

        //xhr.onreadystatechange = function () {
        //    if (xhr.status == 200 && xhr.readyState == 4) {
        //        alert('response: ' + xhr.responseText);
        //    }
        //};
        //xhr.send();
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
    //function createCORSRequest(method, url) {
    //    var xhr = new XMLHttpRequest();
    //    if ("withCredentials" in xhr) {

    //        // Check if the XMLHttpRequest object has a "withCredentials" property.
    //        // "withCredentials" only exists on XMLHTTPRequest2 objects.
    //        xhr.open(method, url, true);

    //    } else if (typeof XDomainRequest != "undefined") {

    //        // Otherwise, check if XDomainRequest.
    //        // XDomainRequest only exists in IE, and is IE's way of making CORS requests.
    //        xhr = new XDomainRequest();
    //        xhr.open(method, url);

    //    } else {

    //        // Otherwise, CORS is not supported by the browser.
    //        xhr = null;

    //    }
    //    return xhr;
    //}
    //function GetSoapResponse() {
    //    //var pl = new SOAPClientParameters();
    //    //SOAPClient.invoke('https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?PobierzDateAktualnegoKatUlic', "HelloWorld", pl, true, GetSoapResponse_callBack);
    //}
    //function GetSoapResponse_callBack(r, soapResponse) {
    //    if (soapResponse.xml)    // IE
    //        alert(soapResponse.xml);
    //    else    // MOZ
    //        alert((new XMLSerializer()).serializeToString(soapResponse));
    //}

    //var xhr = createCORSRequest('GET', url);
    //if (!xhr) {
    //    throw new Error('CORS not supported');
    //}

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
              //  $location.path('/');
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
})();