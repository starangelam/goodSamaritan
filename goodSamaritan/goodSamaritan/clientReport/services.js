(function() {

  var ReportService = function($http, $location) {
    var baseUrl = 'http://a3.angelama.ca/';
    var storage = {
      tokenKey: 'authToken',
      userKey: 'username',
      expireKey: 'expiration'
    };


    var _msgInfo = function(message) {
      $('.console').append('<div class="text-info">' + message + '</div>');
    };

    var _msgSuccess = function(message) {
      $('.console').append('<div class="text-success">' + message + '</div>');
    };

    var _msgError = function(message, status) {
      $('.console').append('<div class="text-danger">' +
        '<b>' + status + ' Error:</b> ' + message +
        '</div>');
    };

    var _noAuth = function() {
      _msgInfo("Not authenticated. Redirect to login.");

      localStorage.removeItem(storage.tokenKey);
      localStorage.removeItem(storage.userKey);
      localStorage.removeItem(storage.expireKey);

      $location.path('/login');
    };
    
    var baseRequest = function(url) {
      return {
        method: 'GET',
        url: url,
        headers: {
          'Authorization': localStorage.getItem(storage.tokenKey)
        }
      };
    };

    var _authenticate = function(loginData) {
      _msgInfo('Authenticating....');

      var data = "grant_type=password" + "&username=" + loginData.userName + "&password=" + loginData.password;

      return $http.post(
        baseUrl + 'Token', data, {
          headers: {
            'Content-Type': 'application/x-www-form-urlencoded'
          }
        }
      )
        .error(function(data, status, headers, config) {
          _msgError(data.error_description, status);
        })
        .success(function(data) {
          _msgSuccess('Login success for user: ' + data.userName);

          var authStr = data.token_type + ' ' + data.access_token;
          localStorage.setItem(storage.tokenKey, authStr);
          localStorage.setItem(storage.userKey, data.userName);
          localStorage.setItem(storage.expireKey, data['.expires']);
        })
        .then(function(response, status, headers, config) {
          return response;
        });
    };

    var _getUser = function() {
      var username = localStorage.getItem(storage.userKey);
      var expiration = localStorage.getItem(storage.expireKey);
      var isValid = false;

      if (username && expiration) {
        var eDate = new Date(expiration);
        var currDate = new Date();
        if (eDate > currDate) {
          isValid = true;
        }
      }

      if (!isValid) {
        _noAuth();
      }

      return username;
    };

    var _getWorkers = function() {
      _msgInfo('Getting all workers...');

      var request = new baseRequest(baseUrl + 'api/Workers');
      return $http(request)
        .error(function(data, status, headers, config) {
          _msgError(data.Message, status);
        })
        .then(function(response, status, headers, config) {
          return response;
        });
    };
    
    var _getStatus = function() {
      _msgInfo('Getting all status...');

      var request = new baseRequest(baseUrl + 'api/StatusOfFiles');
      return $http(request)
        .error(function(data, status, headers, config) {
          _msgError(data.Message, status);
        })
        .then(function(response, status, headers, config) {
          return response;
        });
    };
    
    var _getReport = function(workerId, statusId) {
      _msgInfo('Getting report with workerId: ' 
        + workerId +  ', statusId: ' + statusId + '...');
      
      var url = baseUrl + 'api/Reports/' + workerId + '/Status/' + statusId;
      var request = new baseRequest(url);
      return $http(request)
        .error(function(data, status, headers, config) {
          _msgError(data.Message, status);
        })
        .then(function(response, status, headers, config) {
          return response;
        });
    };

    return {
      logSuccess: _msgSuccess,
      logError: _msgError,
      authenticate: _authenticate,
      revokeAuth: _noAuth,
      getUser: _getUser,
      getWorkers: _getWorkers,
      getStatus: _getStatus,
      getReport: _getReport
    };
  };

  var module = angular.module("goodSamaritan");
  module.factory("ReportService", ReportService);
}());