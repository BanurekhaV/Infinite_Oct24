using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_1.Controllers
{
    public class DemoController : ApiController
    {
       static List<string> continents = new List<string>()
        {
            "Asia",
            "Africa",
            "America",
            "Anartica",
            "Australia",
            "Europe"
        };

        //Get : api/demo
        public IEnumerable<string> Get()
        {
            return continents;
        }

        //get : api/demo/Id
        public string Get(int Id)
        {
            return continents[Id - 1];
        }

        //Post : api/demo
        public IEnumerable<string>Post([FromBody] string data)
        {
            continents.Add(data);
            return continents;
        }

        //Put : api/demo/Id
        public IEnumerable<string> Put(int Id, [FromUri] string c)
        {
            continents[Id - 1] = c;
            return continents;
        }

        //Delete : api/demo/Id
        public IEnumerable<string>Delete(int Id)
        {
            continents.RemoveAt(Id - 1);
            return continents;
        }
    }
}
