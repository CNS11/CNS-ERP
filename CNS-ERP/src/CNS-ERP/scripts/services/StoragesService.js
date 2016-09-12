(function () {
    'use strict';

    angular.module('StoragesServices', ['ngResource'])
    .factory('Storages', Storages);
    Storages.$inject=['$resource'];

    function Storages($resource) {
        return $resource('/api/storages/:id', { id: '@id' }, {
           
            query: { method: 'GET', params: {}, isArray: true },
            get: { method: 'GET', params: { id: '@id' } },
            remove: { method: 'GET', params: { id: '@id' } },
            save: { method: 'POST', params: { storage: '@storage' } },
            update: { method: 'PUT', params: { id: '@id',storage: '@storage' } }
              });
    }


})();