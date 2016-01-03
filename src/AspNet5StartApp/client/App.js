global.angular = require('angular');
global.jQuery = require('jquery');
global.$ = global.jQuery;
import _ from 'lodash';

import angular from 'angular';
import 'angular-animate';
import 'angular-ui-router';
import 'angular-messages';
import 'angular-toastr';
import './home/Home';
import 'angular-local-storage';
import AppController from './AppController';

/* @ngInject */
function appConfig($httpProvider, $urlRouterProvider, localStorageServiceProvider, $logProvider) {

  $httpProvider.useLegacyPromiseExtensions = false;

  $urlRouterProvider.otherwise("/home");

  localStorageServiceProvider.setStorageType('localStorage'); // default

  $logProvider.debugEnabled(true);
}

/* @ngInject */
const App = angular.module('App',
  [
    'ui.router',
    'LocalStorageModule',
    'Home'
  ]);

App.controller('AppController', AppController);
App.config(appConfig);





