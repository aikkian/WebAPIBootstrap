﻿using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class PaymentController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetPayment()
        {
            return Ok("Get Successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostPayment()
        {
            return Ok("Posted.");
        }

        [HttpPut]
        public IHttpActionResult PutPayment()
        {
            return Ok("Updated.");
        }

        [HttpDelete]
        public IHttpActionResult DeletePayment()
        {
            return Ok("Deleted.");
        }
    }
}
