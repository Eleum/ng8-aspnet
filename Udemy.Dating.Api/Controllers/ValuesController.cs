using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Udemy.Dating.Application.Commands;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Application.Queries;
using Udemy.Dating.Domain;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var query = new GetAllValuesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var query = new GetValueQuery(id);
            var result = await _mediator.Send(query);

            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Value value)
        {
            if (!int.TryParse(value.Name, out var val))
                return BadRequest(123);
            
            var command = new AddValueCommand(value);
            var result = await _mediator.Send(command);

            return CreatedAtAction("GetValue", result.Name);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
