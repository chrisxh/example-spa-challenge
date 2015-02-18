angular.module('ScreenDetailsApp', []).controller('ScreenDetailsCtrl', function ($scope, $http) {
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
                for (idx = 0; idx < $scope.screens[i].fields.length;idx++)
                    $scope.fields.push($scope.screens[i].fields[idx]);
                $scope.showField = true;
            }
        }

    }

});