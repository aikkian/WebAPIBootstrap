using System;
using System.Web.Http;

namespace WebApiSample.Controllers
{
    public class ValuesController : ApiController 
    {
        [HttpGet]
        public IHttpActionResult GetValue()
        {
            return Ok("Wow!!!");
        }
    }
}
