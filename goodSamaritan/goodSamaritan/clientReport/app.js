(function() {
  var app = angular.module('goodSamaritan', ['ngRoute']);

  app.config(function($routeProvider) {
    $routeProvider
    .when('/', {
      templateUrl: 'clientReport/report.html',
      controller: 'ReportCtrl'
    })

    .when('/main', {
      templateUrl: 'clientReport/report.html',
      controller: 'ReportCtrl'
    })

    .when('/login', {
      templateUrl: 'clientReport/login.html',
      controller: 'AuthCtrl'
    })

    // catch all
    .otherwise({
      redirectTo: '/login'
    });
  });

  app.controller('MainCtrl', function($scope, ReportService) {
    $scope.showConsole = false;
  });

}());