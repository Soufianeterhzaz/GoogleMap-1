using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using GoogleMap.Models;
using System.Web.Script.Serialization;

namespace GoogleMap.APIControllers
{
    public class AddressController : ApiController
    {
        // GET api/address
        public object Get()
        {
            WebClient wc = new WebClient();
            Address address = new JavaScriptSerializer().Deserialize<Address>(wc.DownloadString(new Uri("http://maps.googleapis.com/maps/api/geocode/json?address=Washington&sensor=false")));

            IList<dynamic> _geoCodes = new List<dynamic>();

            int count = 1;
            foreach (var geoCode in address.results)
            {
                _geoCodes.Add(new
                {
                    Id = count.ToString(),
                    FormattedAddress = geoCode.formatted_address,
                    Lat = geoCode.geometry.location.lat,
                    Lng = geoCode.geometry.location.lng
                });
                count++;
            }

            return new
            {
                Results = _geoCodes
            };
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
