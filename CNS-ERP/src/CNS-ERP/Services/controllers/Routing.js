//app.module('MyApp', ['ngRoute'])
//.config(function($routeProvider,$locationProvider)
//{
//    $routeProvider
//        .when('/',{
//            redirectTo: function()
//            {
//                return '/home';
//            }
//        })
//        .when('/home', {
//        templateUrl: '/Templates/Home.html',
//        controller: 'HomeController'
//        })
//            .when('/about', {
//                templateUrl: '/Templates/About.html',
//                controller: 'AboutController'
//            })
//                .when('/order/:id', {
//                    templateUrl: '/Templates/Order.html',
//                    controller: 'OrderController'
//                })
//                .otherwise({
//                    templateUrl: '/Templates/Error.html',
//                    controller: 'ErrorController'
//                })
//    $locationProvider.html5mode(false).hashPrefix('!');
//                })
//    .controller('HomeController', function ($scope){
//        scope.Message = "This is HOME page";
//    })
//    .controller('AboutController', function ($scope) {
//        scope.Message = "This is ABOUT page";
//    })
//    .controller('OrderController', function ($scope, $routeParams) {
//        scope.Message = "This is ORDER page with string id value"
//            + $routeParams.id;

//    })
//    .controller('StorageController', function ($scope, $routeParams) {
//        scope.Message = "This is STORAGE page" + $routeParams.id;

//    })
//    .controller('ErrorController', function ($scope) {
//        scope.Message = "404 Not Found";
//    })
