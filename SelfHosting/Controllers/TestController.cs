using System.Collections.Generic;
using System.Web.Http;

namespace SelfHosting.Controller
{
    public class TestController : ApiController
    {       
        // GET api/demo 
        public string Get()
        {
            return "Tessst";
        }

        // GET api/demo/5 
        public string Get(int id)
        {
            return "Hello, World!";
        }

        // POST api/demo 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/demo/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/demo/5 
        public void Delete(int id)
        {
        }
    }
}
