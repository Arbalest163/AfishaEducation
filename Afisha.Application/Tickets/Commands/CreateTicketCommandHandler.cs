using Afisha.Application.Common.Exceptions;
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
            var eventR = await _dbContext.Events.FindAsync(new object[] { request.EventId }, cancellationToken);

            var ticket = new Ticket
            {
                Id = Guid.NewGuid(),
                Price = request.Price,
                ClientId = request.ClientId,
                EventId = request.EventId
            };

            if (eventR.CountTicketSold < eventR.MaxCountTicket)
            {
                eventR.CountTicketSold += 1;
            }
            else 
            {
                throw new ExcessException(nameof(Ticket), eventR.MaxCountTicket);
            }

            await _dbContext.Tickets.AddAsync(ticket, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return ticket.Id;
        }
    }
}

