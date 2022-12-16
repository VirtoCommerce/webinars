angular.module('MyLoyalty')
    .controller('MyLoyalty.helloWorldController', ['$scope', 'MyLoyalty.webApi', function ($scope, api) {
        var blade = $scope.blade;
        blade.title = 'MyLoyalty';

        blade.refresh = function () {
            api.get(function (data) {
                blade.title = 'MyLoyalty.blades.hello-world.title';
                blade.data = data.result;
                blade.isLoading = false;
            });
        };

        blade.refresh();
    }]);
