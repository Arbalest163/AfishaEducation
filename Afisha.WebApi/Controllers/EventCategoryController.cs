using Afisha.Application.EventCategories.Commands.CreateEventCategory;
using Afisha.WebApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Afisha.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EventCategoryController : BaseController
    {
        private readonly IMapper _mapper;

        public EventCategoryController(IMapper mapper) => _mapper = mapper;

        [HttpPost("CreateEventCategory")]
        public async Task<ActionResult<Guid>> Create([FromForm] CreateEventCategoryDto createEventCategoryDto)
        {
            var command = _mapper.Map<CreateEventCategoryCommand>(createEventCategoryDto);
            var eventCategoryId = await Mediator.Send(command);
            return Ok(eventCategoryId);
        }

        
    }
}
