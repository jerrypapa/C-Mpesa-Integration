using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B2BMpesaApi.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace B2BMpesaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class B2BController : ControllerBase
    {

        private readonly IMediator _mediator;

        public B2BController(IMediator mediator)
        {

            _mediator = mediator;
        }

        // GET: api/<B2BController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<B2BController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<B2BController>
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] B2bCommand b2CRequest)
        {
            var result = await _mediator.Send(b2CRequest);
            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }


        // PUT api/<B2BController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<B2BController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
