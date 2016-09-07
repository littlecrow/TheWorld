(function () {
    'use strict';

    // getting the existing module
    angular
        .module('app-trips')
        .controller('tripsController', tripsController);

    function tripsController() {
        /* jshint validthis:true */
        var vm = this;
        vm.trips = [
            {
                name: "US Trip",
                created: new Date()
            },
            {
                name: "World Trip",
                created: new Date()
            }];
    }
})();
