/// <reference path="../GMap.js" />

GMap.Models.Address = Backbone.Model.extend({
    idAttribute: 'Id',
    url: "/api/address",
    defaults: {
        "Id": null
    }
});