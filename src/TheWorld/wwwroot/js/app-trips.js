(function () {
    'use strict';

    // creating the module
    angular.module('app-trips', ['simpleControls', 'ngRoute'])
        .config(function ($routeProvider) {

            $routeProvider.when("/", {
                controller: "tripController",
                controllerAs: "vm",
                templateurl: "/views/tripsView.html"
            });

            $routeProvider.otherwise({ redirectTo: "/" });
        })
})();
