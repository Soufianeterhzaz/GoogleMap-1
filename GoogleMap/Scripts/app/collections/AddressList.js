/// <reference path="../GMap.js" />
/// <reference path="../Models/Address.js" />

GMap.Collections.AddressList = Backbone.Collection.extend({
  model: GMap.Models.Address,
  url: "/api/address",

  initialize: function () {
  },

  parse: function (data) {
      return data.Results;
  }
});
