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
    public class LipaNaMpesaAccStatusController : ControllerBase
    {


        private readonly IMediator _mediator;

        public LipaNaMpesaAccStatusController(IMediator mediator)
        {

            _mediator = mediator;
        }


        // GET: api/<LipaNaMpesaAccStatusController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LipaNaMpesaAccStatusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LipaNaMpesaAccStatusController>
     
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] LipaNaMpesaAccStatusCommand b2CRequest)
        {

            var result = await _mediator.Send(b2CRequest);


            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }

        // PUT api/<LipaNaMpesaAccStatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LipaNaMpesaAccStatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
