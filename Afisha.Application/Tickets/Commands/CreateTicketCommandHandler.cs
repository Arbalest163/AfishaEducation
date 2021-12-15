using Afisha.Application.Interfaces;
using Afisha.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Afisha.Application.Tickets.Commands
{
    public class CreateTicketCommandHandler
        : IRequestHandler<CreateTicketCommand, Guid>
    {
        private readonly IAfishaDbContext _dbContext;
        public CreateTicketCommandHandler(IAfishaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            var ticket = new Ticket
            {
                Id = Guid.NewGuid(),
                Price = request.Price,
                ClientId = request.ClientId,
                EventId = request.EventId
            };

            await _dbContext.Tickets.AddAsync(ticket, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return ticket.Id;
        }
    }
}

