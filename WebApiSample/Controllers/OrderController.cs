using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class OrderController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetOrder()
        {
            return Ok("Get Successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostOrder()
        {
            return Ok("Posted.");
        }

        [HttpPut]
        public IHttpActionResult PutOrder()
        {
            return Ok("Updated.");
        }

        [HttpDelete]
        public IHttpActionResult DeleteOrder()
        {
            return Ok("Deleted.");
        }
    }
}
