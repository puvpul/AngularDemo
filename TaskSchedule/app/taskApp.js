
(function () {
    "use strict";
    var app = angular.module("taskApp",
                            ["ngRoute",
                             "dataService"
                             ]);
    app.config(["$routeProvider", "$locationProvider",
        function($routeProvider, $locationProvider) {
            $routeProvider
                .when("/home", {
                    templateUrl: "app/Home.html",
                    controller: "taskController"
                })
                .when("/update", {
                    templateUrl: "app/Update.html",
                    controller: "editTaskController"
                })
                .when("/updateTaskForm/:id", {
                    templateUrl: "app/editTaskTemplate.html",
                    controller: "editTaskController"
                })
                .otherwise({
                    redirectTo: "/home"
                });
            $locationProvider.html5Mode({
                enabled: true,
                requireBase: false
        });
     }]);
}());


