using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MpesaApi.Controllers;
using MpesaApi.Models;
using ReverseTransactionApi.Commands;
using ReverseTransactionApi.Logic;
using ReverseTransactionApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReverseTransactionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseTransactionController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ReverseTransactionController(IMediator mediator)
        {

            _mediator = mediator;
        }
        // GET: api/<ReverseTransactionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReverseTransactionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReverseTransactionController>
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] ReverseTransCommand b2CRequest)
        {

            var result = await _mediator.Send(b2CRequest);

            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }


        // PUT api/<ReverseTransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReverseTransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
