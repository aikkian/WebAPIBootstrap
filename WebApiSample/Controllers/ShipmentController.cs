using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class ShipmentController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetShipment()
        {
            return Ok("Get Successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostShipment()
        {
            return Ok("Posted.");
        }

        [HttpPut]
        public IHttpActionResult PutShipment()
        {
            return Ok("Updated.");
        }

        [HttpDelete]
        public IHttpActionResult DeleteShipment()
        {
            return Ok("Shipment Deleted.");
        }
    }
}
