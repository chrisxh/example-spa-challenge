app.controller('ScreenController', ['$scope', '$location', '$http',
    function ($scope, $location, $http) {
        $scope.screens = [];
        $scope.fields = [];
        $scope.isloading = true;
        var currentfields;
       
        $scope.message = "Hello Screen";
        $http.get("api/Screen/GetScreenList").
        success(function (data) {
            debugger;
            //success from API.
            $scope.screens = data.data;
            $scope.screen = data.data[0];
            
            loadfieldsforscreen($scope.screen.ID)
        }).
        error(function (data) {
            //we can show error stuff on ui too.
            alert("error " + data);
            $scope.isloading = false;
        })


        $scope.loadfields = function (e) {

            loadfieldsforscreen($scope.screen.ID);

        };

        function loadfieldsforscreen(screenid) {
            debugger;
            $http.get("api/Screen/Fields?Id=" + screenid).
       success(function (data) {
           debugger;
           //success from API.
           $scope.fields = data;

           currentfields = $scope.fields[0];
           $scope.field = currentfields[0];
           $scope.isloading = false;
       }).
       error(function (data) {
           //we can show error stuff on ui too.
           alert("error " + data);
           $scope.isloading = false;
       })



        }

    }



]);