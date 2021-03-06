﻿(function () {
    'use strict';

    config.$inject = ['$routeProvider', '$locationProvider'];

    angular.module('CNSS-App', [
        'ngMaterial','ngMessages','ngRoute', "ng", "ngAnimate", "ngAria", 'StoragesServices', 'TestServices', 
    ]).config(config)
        
    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/Views/Storages/list.html',
                controller: 'storagesListController'
            })
            .when('/storages/list', {
                templateUrl: '/Views/Storages/list.html',
                controller: 'storagesListController'
            })
            .when('/storages/add', {
                templateUrl: '/Views/Storages/add.html',
                controller: 'storagesAddController'
            })
            .when('/storages/edit/:id', {
                templateUrl: '/Views/Storages/edit.html',
                controller: 'storagesEditController'
            })
            .when('/storages/delete/:id', {
                templateUrl: '/Views/Storages/delete.html',
                controller: 'storagesDeleteController'
            });
        $locationProvider.html5Mode(true);
    }

})();