window.GMap = {};

GMap.Models = {};
GMap.Collections = {};
GMap.Routers = {};
GMap.Views = {};
GMap.Globals = {};
GMap.Defaults = {};
GMap.Validations = {};
GMap.Controllers = {};
GMap.Mixins = {};
GMap.Regions = {};

GMap.App = new Backbone.Marionette.Application();
GMap.App.addRegions({
  appRegion: '#app-view'
});

GMap.App.on('initialize:after', function () {
  //TODO FIND ALL CQ.GLOBALS and KILL THEM!!!
  if (!Backbone.History.started) Backbone.history.start({ pushState: true });
});

GMap.App.commands.setHandler("setup", function (options) {

  GMap.App.appRegion.on('show', function () {
    GMap.App.vent.trigger('app:rendered');
  });

  GMap.Globals.mapRouter = new GMap.Routers.MapRouter();
});

GMap.App.addInitializer(function (options) {
  GMap.App.execute("setup", options);
});