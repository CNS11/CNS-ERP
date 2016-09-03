
(function () {
    'use strict';

    config.$inject = ['$routeProvider', '$locationProvider'];

    var app = angular.module('moviesApp', []);
    app.config(['$routeProvider',
                function ($routeProvider) {
                    $routeProvider.
                    when('/', {
                        templateUrl: '/Views/list.html',
                        controller: 'MoviesListController'
                    })
                    .when('/movies/add', {
                        templateUrl: '/Views/add.html',
                        controller: 'MoviesAddController'
                    })
                    .when('/movies/edit/:id', {
                        templateUrl: '/Views/edit.html',
                        controller: 'MoviesEditController'
                    })
                    .when('/movies/delete/:id', {
                        templateUrl: '/Views/delete.html',
                        controller: 'MoviesDeleteController'
                    });
                }]);

    app.controller('MoviesListController', function ($scope) {
    });
});