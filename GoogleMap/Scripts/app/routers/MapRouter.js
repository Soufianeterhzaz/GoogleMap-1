/// <reference path="../GMap.js" />

GMap.Routers.MapRouter = Backbone.Router.extend({
  routes: {
    "": "index"
  },

  index: function () {
    this.appView = new GMap.Views.AppView();
    GMap.App.appRegion.show(this.appView);
  },

  initialize: function () {
  }
});