using MediatR;
using System;

namespace Afisha.Application.Tickets.Commands
{
    public class CreateTicketCommand : IRequest<Guid>
    {
        public uint Price { get; set; }
        public DateTime DateEvent { get; set; }
        public Guid ClientId { get; set; }
        public Guid EventId { get; set; }
    }
}
