using Afisha.Application.Common.Mappings;
using Afisha.Application.Tickets.Commands;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.WebApi.Models
{
    public class CreateTicketDto : IMapWith<CreateTicketCommand>
    {
        public uint Price { get; set; }
        public Guid ClientId { get; set; }
        public Guid EventId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateTicketDto, CreateTicketCommand>();
        }
    }
}
