using Afisha.Application.Tickets.Commands;
using Afisha.WebApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TicketController : BaseController
    {
        private readonly IMapper _mapper;

        public TicketController(IMapper mapper) => _mapper = mapper;

        [HttpPost("CreateTicket")]
        public async Task<ActionResult<Guid>> Create([FromForm] CreateTicketDto createEventCategoryDto)
        {
            var command = _mapper.Map<CreateTicketCommand>(createEventCategoryDto);
            var eventCategoryId = await Mediator.Send(command);
            return Ok(eventCategoryId);
        }
    }
}
