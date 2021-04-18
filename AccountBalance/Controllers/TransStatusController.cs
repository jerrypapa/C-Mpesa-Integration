using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TransactionStatusApi.Commands;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountBalance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransStatusController : ControllerBase
    {


        private readonly IMediator _mediator;

        public TransStatusController(IMediator mediator)
        {

            _mediator = mediator;
        }

        // GET: api/<AccountBalanceController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountBalanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountBalanceController>
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] TransStatusCommand b2CRequest)
        {
            var result = await _mediator.Send(b2CRequest);

            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }


        // PUT api/<AccountBalanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountBalanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
