using B2CMpesaApi.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace B2CMpesaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class B2CController : ControllerBase
    {
        private readonly IMediator _mediator;

        public B2CController(IMediator mediator)
        {

            _mediator = mediator;
        }



        // GET: api/<B2CController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<B2CController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<B2CController>
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] B2CCommand b2CRequest)
        {
            var result = await _mediator.Send(b2CRequest);
            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }


        // PUT api/<B2CController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<B2CController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
