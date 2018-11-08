using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class IndexController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetIndex()
        {
            return Ok("Get Successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostIndex()
        {
            return Ok("Posted.");
        }

        [HttpPut]
        public IHttpActionResult PutIndex()
        {
            return Ok("Updated.");
        }

        [HttpDelete]
        public IHttpActionResult DeleteIndex()
        {
            return Ok("Deleted.");
        }
    }
}
