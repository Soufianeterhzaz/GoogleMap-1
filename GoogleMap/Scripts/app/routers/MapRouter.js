/// <reference path="../GMap.js" />

GMap.Routers.MapRouter = Backbone.Router.extend({
  routes: {
    "": "index"
  },

  index: function () {
    this.appView = new GMap.Views.AppView({
      collection: this.addressList
    });
    GMap.App.appRegion.show(this.appView);
  },

  initialize: function () {
    this.addressList = GMap.App.request('addressList');
  }
});