var app = angular.module('app', ['ngRoute']);

app.config(function ($routeProvider) {


    $routeProvider
       

     .when('/', {
         templateUrl: "Pages/Screen.html",
         controller: 'ScreenController'
     });
});