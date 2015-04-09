(function() {
  var module = angular.module('goodSamaritan');

  var AuthenticationController = function($scope, $location, ReportService) {
    ReportService.logSuccess('auth ctrl called.');
    $scope.submitted = false;
    $scope.failed = false;
    
    var onSuccess = function(response) {
      $scope.failed = false;
      // redirect to report page
      $location.path('/main');
    };
    
    var onError = function(response) {
      $scope.failed = true;
      $scope.errorMsgs = response.data.error_description;
    };
    
    $scope.login = function() {
      $scope.submitted = true;
      var data = {
        userName: $scope.user.email,
        password: $scope.user.password
      };
      ReportService.authenticate(data)
      .then(onSuccess, onError);
    };
  };

  module.controller("AuthCtrl", AuthenticationController);
}());