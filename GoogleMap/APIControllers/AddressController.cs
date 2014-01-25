using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoogleMap.APIControllers
{
    public class AddressController : ApiController
    {
        // GET api/address
        public object Get()
        {
            WebClient wc = new WebClient();
            string address = wc.DownloadString(new Uri("http://maps.googleapis.com/maps/api/geocode/json?address=1600 Amphitheatre Parkway, Mountain+View, CA&sensor=false"));
            return new
            {
                //Results = results,
                Count = 0
            };
        }
    }
}
