

(function () {
    "use strict";
    angular
        .module("taskApp")
        .controller("taskController",
                    ["taskResource","$location","$routeParams",
                        taskController]);

    function taskController(taskResource,$location,$routeParams) {
        var vm = this;
        
        taskResource.query(function(data) {
            vm.jobs = data;
        });

        vm.showUpdateTask = function (id) {
            //$location.path('/updateTaskForm/' + id);
            $location.path('/update');
        };
    }
}());