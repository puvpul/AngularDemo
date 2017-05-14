angular.module('app').factory('dataService', function ($http, $q, $rootScope, apiValues) {
    
    var _allTasks = [];
    var _getTaskList = function () {

        var deferred = $q.defer();

        $http.get("http://localhost:3560/api/TaskListService")
          .then(function (result) {
              // Successful
              angular.copy(result.data, _allTasks);
              console.log(_allTasks);
              alert("hey");
              _isInit = true;
              deferred.resolve();
          },
          function () {
              // Error
              deferred.reject();
              alert("hey");
          });

        return deferred.promise;
    };
    return {
        allTasks:_allTasks,
        getTaskList: _getTaskList,
       
    };
});