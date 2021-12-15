using Afisha.Application.Events.Commands;
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
    public class EventController : BaseController

    {
        private readonly IMapper _mapper;

        public EventController(IMapper mapper) => _mapper = mapper;

        [HttpPost("CreateEvent")]
        public async Task<ActionResult<Guid>> Create([FromForm] CreateEventDto createEventCategoryDto)
        {
            var command = _mapper.Map<CreateEventCommand>(createEventCategoryDto);
            var eventCategoryId = await Mediator.Send(command);
            return Ok(eventCategoryId);
        }
    }
}
