(function () {
    "use strict";

    angular
        .module("dataService")
        .factory("taskResource",
                ["$resource",
                 taskResource]);

    function taskResource($resource) {
        //return $resource("/api/jobs/:taskId");//akane jodi add
      
        return $resource("http://localhost:3560/Api/TaskListService");
    }

}());
