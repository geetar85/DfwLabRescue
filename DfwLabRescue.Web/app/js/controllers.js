//var dfwLabRescueControllers = angular.module('dfwLabRescueControllers', []);

//dfwLabRescueControllers.controller('HomeCtrl', ['$scope', '$http', function ($scope, $http) {
//    $http.get('/dogs/available?ps=4').success(function (data) {
//        $scope.availableDogs = data;
//    });
//}]);

//dfwLabRescueControllers.controller('DogDetailCtrl', ['$scope', '$http', '$routeParams', function ($scope, $http, $routeParams) {
//    $http.get('/dogs/' + $routeParams.id).success(function (data) {
//        $scope.dog = data;
//    });
//}]);

var dfwLabRescueApp = angular.module('dfwLabRescueApp', []);

dfwLabRescueApp.controller('AdminDogCtrl', function ($scope, $http) {
    $http.get('/api/dogs?ps=4').success(function (data) {
        $scope.dogs = data;
    });
});

//dfwLabRescueApp.controller("StoreCtrl", function ($scope, $http) {
//    $http.jsonp('http://widgets.cafepress.com/search/show/dfwlrrc?type=shop&callback=JSON_CALLBACK').success(function (data) {
//        $scope.products = data.product;
//    })
//});