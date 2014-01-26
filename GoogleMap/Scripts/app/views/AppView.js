/// <reference path="../GMap.js" />

GMap.Views.AppView = Backbone.Marionette.Layout.extend({
  template: '#app-view-template',
  className: 'main-container',

  regions: {
    mapCanvas: '#map-canvas',
    addressBox: '#address-box'
  },

  initialize: function (options) {
    var self = this;
    this.collection = options.collection;
    this.collection.fetch({
        success: function (data) {
            self.showMap();
        }
    });

    //google.maps.event.addDomListener(window, 'load', this.showMap);
  },

  showMap: function () {
    var map_canvas = $('#map-canvas');
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
    this.collection.each(function (item) {
        new google.maps.Marker({
            position: new google.maps.LatLng(item.get('Lat'), item.get('Lng')),
            map: map,
            title: item.get('FormattedAddress')
        });
    });
  },

  onRender: function () {
    this.addressBox.show(new GMap.Views.AddressView({      
    }));
  }
});