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
    var map_canvas = this.$('#map_canvas');
    console.log(map_canvas);
    var map_options = {
      center: new google.maps.LatLng(44.5403, -78.5463),
      zoom: 8,
      mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    var map = new google.maps.Map(this.$('#map_canvas')[0], map_options);
  },

  onRender: function () {
  }
});