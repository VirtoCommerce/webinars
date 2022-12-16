angular.module('MyLoyalty')
    .factory('MyLoyalty.webApi', ['$resource', function ($resource) {
        return $resource('api/my-loyalty');
    }]);
