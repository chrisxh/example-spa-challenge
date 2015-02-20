﻿angular.module('ScreenDetailsApp', []).controller('ScreenDetailsCtrl', function ($scope, $http) {
    $scope.title = "loading screen.....";
    $scope.working = false;
    $scope.showField = false;
   

    $scope.getScreens = function () {
        $scope.working = true;
        $scope.title = 'loading screens .......';
        $http.get('api/ScreenDetails').success(function (data, status, headers, config) {
            $scope.screens = data;
            $scope.working = false;
        }).error(function (data, status, headers, config) {
            $scope.title = 'Oops something went wrong';
            $scope.working = false;});
    };
    $scope.getFields = function (screenId) {
        $scope.fields = [];
        for(i=0;i<$scope.screens.length; i++)
        {
            if ($scope.screens[i].id === screenId)
            {
                for (idx = 0; idx < $scope.screens[i].fields.length; idx++) {
                    if ($scope.screens[i].fields[idx].status === 0)
                    {
                        $scope.screens[i].fields[idx].bgcolor = 'visible';
                        $scope.screens[i].fields[idx].status = 'Visible';
                    }
                    else if ($scope.screens[i].fields[idx].status === 1)
                    {
                        $scope.screens[i].fields[idx].bgcolor = 'hide1';
                        $scope.screens[i].fields[idx].status = 'Hidden';
                    }
                    else
                    {

                        $scope.screens[i].fields[idx].bgcolor = 'disabled';
                        $scope.screens[i].fields[idx].status = 'Disabled';
                    }
                    $scope.fields.push($scope.screens[i].fields[idx]);
                }
           }
        }

    }

});