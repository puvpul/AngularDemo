angular.module('app').controller('taskListCtrl', ['$scope', 'dataService', 'apiValues',
function ($scope, dataService, apiValues) {
    
    $scope.TaskList = [];
  

    dataService.getTaskList().then(function (data) {
            $scope.TaskList = data;
            console.log($scope.TaskList);
        }, function (err) {
            $scope.GLOBAL_ERROR = true;
        })
   
}]);