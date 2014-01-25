/// <reference path="../GMap.js" />

GMap.Collections.AddressList = Backbone.Collection.extend({
  model: GMap.Models.Address,
  url: "/api/address",

  initialize: function () {
  }
});
