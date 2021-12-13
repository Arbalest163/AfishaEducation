using Afisha.Application.Clients.Commands.CreateClient;
using Afisha.Application.Clients.Queries.GetClientList;
using Afisha.WebApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Afisha.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : BaseController
    {
        private readonly IMapper _mapper;

        public ClientController(IMapper mapper) => _mapper = mapper;

        [HttpGet("ClientList")]
        public async Task<ActionResult<ClientListVm>> Get(string query = null)
        {
            var returnClientList = new GetClientListQuery
            {
                Query = query
            };
            var vm = await Mediator.Send(returnClientList);
            return Ok(vm);
        }

        [HttpPost("CreateClient")]
        public async Task<ActionResult<Guid>> Create([FromForm] CreateClientDto createClientDto)
        {
            var command = _mapper.Map<CreateClientCommand>(createClientDto);
            var clientId = await Mediator.Send(command);
            return Ok(clientId);
        }

        [HttpPost("CreateRnd")]
        public async Task<ActionResult> CreateRandom(int count, [FromForm] CreateClientRandom createClientRandom)
        {
            int i = 0;
            while (i < count)
            {
                var rndName = new Random().Next(0, createClientRandom.FirstName.Count);
                var rndLastName = new Random().Next(0, createClientRandom.LastName.Count);
                var rndMiddleName = new Random().Next(0, createClientRandom.MiddleName.Count);
                var rndBirthday = new Random().Next(0, createClientRandom.Birthday.Count);

                var clientDto = new CreateClientDto
                {
                    FirstName = createClientRandom.FirstName[rndName],
                    LastName = createClientRandom.LastName[rndLastName],
                    MiddleName = createClientRandom.MiddleName[rndMiddleName],
                    Birthday = createClientRandom.Birthday[rndBirthday]
                };

                var command = _mapper.Map<CreateClientCommand>(clientDto);

                await Mediator.Send(command);

                i++;
            }
               
            return Ok();
        }

        [HttpPost("CreateRndMaleCount")]
        public async Task<ActionResult> CreateMaleCountRandom(int count)
        {
            int i = 0;
            while (i < count)
            {
                var clientDto = CreateClientFactory.CreateMale();
                var command = _mapper.Map<CreateClientCommand>(clientDto);

                await Mediator.Send(command);

                i++;
            }

            return Ok();
        }

        [HttpPost("CreateRndFemaleCount")]
        public async Task<ActionResult> CreateFemaleCountRandom(int count)
        {
            int i = 0;
            while (i < count)
            {
                var clientDto = CreateClientFactory.CreateFemale();
                var command = _mapper.Map<CreateClientCommand>(clientDto);

                await Mediator.Send(command);

                i++;
            }

            return Ok();
        }
    }
}
