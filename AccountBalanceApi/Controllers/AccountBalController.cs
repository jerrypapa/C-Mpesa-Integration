using System.Collections.Generic;
using System.Threading.Tasks;
using AccountBalanceApi.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;



namespace AccountBalanceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountBalController : ControllerBase
    {

        private readonly IMediator _mediator;


        public AccountBalController(IMediator mediator)
        {

            _mediator = mediator;
        }

        // GET: api/<AccountBalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountBalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountBalController>
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] AccountBalanceCommand b2CRequest)
        {

            var result = await _mediator.Send(b2CRequest);

            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }

        // PUT api/<AccountBalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountBalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
