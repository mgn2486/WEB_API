using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_1.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<string> strings = new List<string>()
        {
            "Value-1","Value-2","Value-3","Value-4"
        };
        // GET api/values
        public List<string> Get()
        {
            return strings;
        }

        // GET api/values/5
        [HttpGet]
        public string Get(int id)
        {
            return strings[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
