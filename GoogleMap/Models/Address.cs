using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace GoogleMap.Models
{
    public class Address
    {
        public GeoCode[] results { get; set; }
        public string status { get; set; }
    }

    public class GeoCode
    {
        public AddressComponent[] address_components { get; set; }
        public string formatted_address { get; set; }
        public Geometry geometry { get; set; }
        public string[] types { get; set; }
    }

    public class AddressComponent 
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public string[] types { get; set; }
    }

    public class Geometry
    {
        public Bound bounds { get; set; }
        public Location location { get; set; }
        public string location_type { get; set; }
        public ViewPort viewport { get; set; }
    }

    public class Bound
    {
        public Location northeast { get; set; }
        public Location southwest { get; set; }
    }

    public class ViewPort
    {
        public Location northeast { get; set; }
        public Location southwest { get; set; }
    }

    public class Location
    {
        public decimal lat { get; set; }
        public decimal lng { get; set; }
    }
}