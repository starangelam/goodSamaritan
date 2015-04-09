(function() {
  var module = angular.module('goodSamaritan');

  var ReportController = function($scope, $q, ReportService) {
    var onGetReportSuccess = function(response) {
      $scope.report = response.data;
      $scope.report.date = new Date().toDateString();
    };

    var onGetFilterOptionSuccess = function(responseArray) {
      var workResponse = responseArray[0];
      if (workResponse !== null) {
        $scope.workers = workResponse.data;
        if ($scope.workers[0] !== null) {
          $scope.selectedWorker = $scope.workers[0].AssignedWorkerId;
        }
      }

      var statusResponse = responseArray[1];
      if (statusResponse !== null) {
        $scope.statuses = statusResponse.data;
        if ($scope.statuses[0] !== null) {
          $scope.selectedStatus = $scope.statuses[0].StatusOfFileId;
        }
      }

      // Get 1st report
      if ($scope.selectedWorker !== null && $scope.selectedStatus !== null) {
        ReportService.getReport($scope.selectedWorker, $scope.selectedStatus)
          .then(onGetReportSuccess);
      }
    };

    // Page initialization
    $scope.username = ReportService.getUser();
    var filterPromises = [
      ReportService.getWorkers(),
      ReportService.getStatus()
    ];
    $q.all(filterPromises).then(onGetFilterOptionSuccess);

    $scope.logout = function() {
      ReportService.revokeAuth();
    };
    $scope.getReport = function() {
      ReportService.getReport($scope.selectedWorker, $scope.selectedStatus)
        .then(onGetReportSuccess);
    };

    $scope.months = [
      'January',
      'Feburary',
      'March',
      'April',
      'May',
      'June',
      'July',
      "August",
      'September',
      'October',
      'November',
      'December'
    ];
  };

  module.controller("ReportCtrl", ReportController);

}());