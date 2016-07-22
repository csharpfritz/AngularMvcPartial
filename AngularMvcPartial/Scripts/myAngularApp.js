(function () {

    var app = angular.module('siteProcessing', []);
    app.controller('clientSetup', function ($scope, $http) {

        var viewModel = this;
        viewModel.OpenDialog = function (tenantId) {

            // Open dialog
            $("#ClientSetupDlg")
            .dialog(
               {
                   width: 700,
                   height: 700,
                   title: "Edit Site Payment",
                   modal: true,
                   draggable: true,
                   resizable: true,
                   closeOnEscape: true
               });

            // Load the data
            $http.get('/home/ClientInformation/' + tenantId.toString())
            .success(function (response, status, headers, config) {
                $scope.response = response;
                $scope.status = status;
            }).error(function (data, status, headers, config) {
                $scope.status = status;
            });

        }

        //save the data
        viewModel.submit = function () {
            $http({
                url: "/home/SaveClientInformation",
                method: "POST",
                data: $scope.response
            }).success(function (data, status, headers, config) {
                $scope.data = data;
            }).error(function (data, status, headers, config) {
                $scope.status = status;
            });
        };



    });
})();

