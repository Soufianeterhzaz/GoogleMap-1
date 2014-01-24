/// <reference path="../GMap.js" />

GMap.Views.AppView = Backbone.Marionette.Layout.extend({
  template: '#app-view-template',
  className: 'main-container',

  regions: {
    mapCanvas: "#map-canvas"
  },

  initialize: function (options) {
      google.maps.event.addDomListener(window, 'load', this.showMap);
  },

  showMap: function () {
      var map_canvas = $('#map_canvas');
      var map_options = {
          center: new google.maps.LatLng(44.5403, -78.5463),
          zoom: 3,
          mapTypeId: google.maps.MapTypeId.ROADMAP,
          mapTypeControl: false,
          panControl: true,
          panControlOptions: {
              position: google.maps.ControlPosition.RIGHT_BOTTOM
          },
          zoomTypeControl: true,
          zoomControlOptions: {
              style: google.maps.ZoomControlStyle.LARGE,
              position: google.maps.ControlPosition.RIGHT_BOTTOM
          }
      }
      var map = new google.maps.Map(map_canvas[0], map_options);
  },

  onRender: function () {
  }
});