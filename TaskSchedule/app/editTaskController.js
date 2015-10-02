(function () {
    "use strict";

    angular
        .module("taskApp")
        .controller("editTaskController",
        ["product","$routeParams",
            editTaskController]);


    function editTaskController(product, $routeParams) {
        var vm = this;

        vm.product = product;

       
    }
}());