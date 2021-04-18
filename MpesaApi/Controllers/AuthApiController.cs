using Microsoft.AspNetCore.Mvc;
using MpesaApi.Logic;
using MpesaApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MpesaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        GetMpesaTokenAsnyc getMpesaTokenAsync = new GetMpesaTokenAsnyc();
        // GET: api/<AuthApi>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthApi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthApi>
        [HttpPost]
        public  Object GetAccessToken([FromBody] TokenRequest tokenRequest)
        {



            var result = getMpesaTokenAsync.GetToken(tokenRequest);

            return result;

            ///return (result != null ? (IActionResult)Ok(result) : NotFound());
        }

        // PUT api/<AuthApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
