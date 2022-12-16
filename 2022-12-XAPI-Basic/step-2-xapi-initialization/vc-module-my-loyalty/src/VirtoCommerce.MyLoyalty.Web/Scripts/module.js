// Call this to register your module to main application
var moduleName = 'MyLoyalty';

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('workspace.MyLoyaltyState', {
                    url: '/MyLoyalty',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        'platformWebApp.bladeNavigationService',
                        function (bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: 'MyLoyalty.helloWorldController',
                                template: 'Modules/$(VirtoCommerce.MyLoyalty)/Scripts/blades/hello-world.html',
                                isClosingDisabled: true,
                            };
                            bladeNavigationService.showBlade(newBlade);
                        }
                    ]
                });
        }
    ])
    .run(['platformWebApp.mainMenuService', '$state',
        function (mainMenuService, $state) {
            //Register module in main menu
            var menuItem = {
                path: 'browse/MyLoyalty',
                icon: 'fa fa-cube',
                title: 'MyLoyalty',
                priority: 100,
                action: function () { $state.go('workspace.MyLoyaltyState'); },
                permission: 'MyLoyalty:access',
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
