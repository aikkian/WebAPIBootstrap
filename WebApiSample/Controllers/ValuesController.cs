using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class ValuesController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetValues()
        {
            return Ok("Get Successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostValues()
        {
            return Ok("Posted.");
        }

        [HttpPut]
        public IHttpActionResult PutValues()
        {
            return Ok("Updated.");
        }

        [HttpDelete]
        public IHttpActionResult DeleteValues()
        {
            return Ok("Deleted.");
        }
    }
}
