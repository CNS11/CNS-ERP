(function () {
    'use strict';

    var StorageService = angular.module('storageServices', ['ngResource']);

    StorageService.factory('Storages', ['$resource', function ($resource) {
        return $resource('/api/storages/', {}, {
            query: { method: 'GET', params: {}, isArray: true }

        });
    }]);
});