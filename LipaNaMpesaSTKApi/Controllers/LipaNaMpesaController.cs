using LipaNaMpesaSTKApi.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LipaNaMpesaSTKApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LipaNaMpesaController : ControllerBase
    {



        private readonly IMediator _mediator;

        public LipaNaMpesaController(IMediator mediator)
        {

            _mediator = mediator;
        }


        // GET: api/<LipaNaMpesaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LipaNaMpesaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LipaNaMpesaController>
        [HttpPost]
      
        public async Task<IActionResult> B2cTransact([FromBody] LipaNaMpesaCommand b2CRequest)
        {

            var result = await _mediator.Send(b2CRequest);
            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }

        // PUT api/<LipaNaMpesaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LipaNaMpesaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
