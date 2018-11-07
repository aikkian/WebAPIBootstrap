using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class ValuesController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetValue()
        {
            return Ok("Get Successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostValue()
        {
            return Ok("Posted.");
        }

        [HttpPut]
        public IHttpActionResult PutValue()
        {
            return Ok("Updated.");
        }
    }
}
