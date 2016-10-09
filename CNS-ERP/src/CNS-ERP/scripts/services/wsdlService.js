(function () {
    'use strict';

    angular.module('TestServices', ['ngResource'])
    .factory('TestTestServices' ['$soap', function ($soap) {
        var base_url = "https://uslugaterytws1test.stat.gov.pl/TerytWs1.svc?singleWsdl";

        return {
            HelloWorld: function () {
                return $soap.post(base_url, "HelloWorld");
            }
        }
    }]);


})();