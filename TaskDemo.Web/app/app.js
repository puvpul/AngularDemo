var app = angular.module('app', ['ui.bootstrap']);





app.value('apiValues', {
    GLOBAL_ERROR: false,
    baseUrl: '',
    isSubmitting: false
});

app.run(['$rootScope','apiValues', function ($rootScope, apiValues) {
   
    $rootScope.isSumbitting = 0;
    $rootScope.Global_RegID = "";
    apiValues.baseUrl = webApiBaseUrl;

}]);