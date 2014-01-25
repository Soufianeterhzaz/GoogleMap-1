using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace GoogleMap.APIControllers
{
    public class AddressController : ApiController
    {
        // GET api/address
        public object Get()
        {
            WebClient wc = new WebClient();
            string addressList = wc.DownloadString(new Uri("http://maps.googleapis.com/maps/api/geocode/json?address=1600+Amphitheatre+Parkway,+Mountain+View,+CA&sensor=false"));
            return null;
        }

        // GET api/address/5
        public object Get(int id)
        {
            return new
            {
                Result = "test"
            };
        }

        // POST api/address
        public void Post([FromBody]string value)
        {
        }

        // PUT api/address/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/address/5
        public void Delete(int id)
        {
        }
    }
}

