(function () {
    'use strict';

    // getting the existing module
    angular
        .module('app-trips')
        .controller('tripsController', tripsController);

    function tripsController() {
        /* jshint validthis:true */
        var vm = this;
        vm.name = 'Little Crow';
    }
})();
