﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C2BMpesaAPI.Commands;
using C2BMpesaAPI.Logic;
using C2BMpesaAPI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MpesaApi.Controllers;
using MpesaApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C2BMpesaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterURLSController : ControllerBase
    {




        private readonly IMediator _mediator;

        public RegisterURLSController(IMediator mediator)
        {

            _mediator = mediator;
        }
        // GET: api/<RegisterURLSController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RegisterURLSController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegisterURLSController>
        [HttpPost]
        public async Task<IActionResult> B2cTransact([FromBody] RegisterURLCommand b2CRequest)
        {
            var result = await _mediator.Send(b2CRequest);
            return (result != null ? (IActionResult)Ok(result) : NotFound());
        }

        // PUT api/<RegisterURLSController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegisterURLSController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
