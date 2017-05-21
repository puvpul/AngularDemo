angular.module('app').factory('dataService', function ($http, $q, $rootScope, apiValues) {
    
    var _allTasks = [];
    var _getTaskList = function () {

        var deferred = $q.defer();

        $http.get("http://localhost:3560/api/TaskListService")
          .then(function (result) {
              deferred.resolve(result.data);
          },
          function (error) {
              // Error
              deferred.rejecterror
              console.log(error);
              
          });

        return deferred.promise;
    };
    return {
        allTasks:_allTasks,
        getTaskList: _getTaskList,
       
    };
});