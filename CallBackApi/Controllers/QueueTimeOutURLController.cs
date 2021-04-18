using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallBackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueTimeOutURLController : ControllerBase
    {
        // GET: api/<QueueTimeOutURLController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QueueTimeOutURLController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QueueTimeOutURLController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var tokenResponse = JsonConvert.DeserializeObject<String>(value);
        }

        // PUT api/<QueueTimeOutURLController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QueueTimeOutURLController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
