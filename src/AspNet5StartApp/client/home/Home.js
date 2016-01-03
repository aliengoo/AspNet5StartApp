import angular from 'angular';
import HomeController from './HomeController';

import template from './Home.html';

const Home = angular.module('Home', [
  'ui.router',
  'ngAnimate',
  'ngMessages',
  'toastr',
  'LocalStorageModule'
]);

Home.config(function($stateProvider) {
  $stateProvider.state('home', {
    url: '/home',
    template,
    controller: HomeController
  });
});

export default Home;
