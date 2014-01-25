/// <reference path="../GMap.js" />

GMap.Models.Address = Backbone.Model.extend({
  idAttribute: 'Id',
  defaults: {
    "Id": null,
    "FormattedAddress": null,
    "Lat": null,
    "Lng": null
  }
});
