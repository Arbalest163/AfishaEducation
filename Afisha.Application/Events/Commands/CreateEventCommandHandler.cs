using Afisha.Application.Interfaces;
using Afisha.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Afisha.Application.Events.Commands
{
    public class CreateEventCommandHandler
        : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IAfishaDbContext _dbContext;
        public CreateEventCommandHandler(IAfishaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = new Event
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                EventCategoryId = request.EventCategoryId,
                DateStart = request.DateStart,
                DateEnd = request.DateEnd,
                Country = request.Country,
                City = request.City,
                Place = request.Place,
                Description = request.Description,
                AgeRestriction = request.AgeRestriction,
                MaxCountTicket = request.MaxCountTicket
            };

            await _dbContext.Events.AddAsync(@event, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return @event.Id;
        }
    }
}
