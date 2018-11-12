using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class ShipmentController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetShip()
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
