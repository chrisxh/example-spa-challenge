var ScreenApp = angular.module('ScreenApp', [
'ngRoute',
'ngAnimate']);

ScreenApp.config(['$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/Screen/:id', {
                templateUrl: 'Home/FieldsTemplate',
                controller: 'FieldsController'
            });

    }
]);

ScreenApp.controller("screenController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
        $scope.selectActive = function(screen) {
            $scope.Screens.forEach(function(screenInner) {
                screenInner.IsActive = false;
            });
            screen.IsActive = true;
        }
        var reg = /[0-9]$/;
        var HashId = reg.exec($location.path());
        $http.get('api/screens')
            .success(function (data) {
                data.forEach(function (screen, index) {
                    if (HashId != null && screen.ID == HashId) {
                        screen.IsActive = true;
                        document.location.href = "#/Screen/" + screen.ID;
                    }
                    else {
                        if (index == 0 && HashId == null) {
                            screen.IsActive = true;
                            document.location.href = "#/Screen/" + screen.ID;
                        }
                        else {
                            screen.IsActive = false;
                        }
                    }
                });
                $scope.Screens = data;
        });
    }
]);

ScreenApp.controller("FieldsController", ["$scope", "$http", "$routeParams", function ($scope, $http, $routeParams) {
    $http.get('api/screens/' + $routeParams.id)
        .success(function(data) {
            data.Fields.forEach(function(field) {
                field.IsVisible = field.Status == 'Visible';
                field.IsHidden = field.Status == 'Hidden';
                field.IsDisabled = field.Status == 'Disabled';
            });
            $scope.Fields = data.Fields;
    });
}
]);
