namespace ScrapsPlus {

    angular.module('ScrapsPlus', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: ScrapsPlus.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: ScrapsPlus.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: ScrapsPlus.Controllers.LoginController,
                controllerAs: 'controller'
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: ScrapsPlus.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('registerPartTwo', {
                url: '/registerPartTwo',
                templateUrl: '/ngApp/views/registerPartTwo.html',
                controller: ScrapsPlus.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: ScrapsPlus.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            })
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('profile', {
                url: '/profile',
                templateUrl: '/ngApp/views/profile.html',
                controller: ScrapsPlus.Controllers.ProfileController,
                controllerAs: 'controller'
            })
            .state('admin', {
                url: '/admin',
                templateUrl: '/ngApp/views/adminHomePage.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('customerHome', {
                url: '/customerHome',
                templateUrl: '/ngApp/views/customerHomePage.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('subscription', {
                url: '/subscription',
                templateUrl: '/ngApp/views/subscription.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('bronze', {
                url: '/bronze',
                templateUrl: '/ngApp/views/bronzeOption.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('silver', {
                url: '/silver',
                templateUrl: '/ngApp/views/silverOption.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('gold', {
                url: '/gold',
                templateUrl: '/ngApp/views/goldOption.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('checkOut', {
                url: '/checkOut',
                templateUrl: '/ngApp/views/checkOut.html',
                controller: ScrapsPlus.Controllers.AboutController,
                controllerAs: 'controller'
            })

            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });


    angular.module('ScrapsPlus').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('ScrapsPlus').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });



}
