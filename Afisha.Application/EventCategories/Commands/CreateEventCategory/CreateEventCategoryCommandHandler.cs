using Afisha.Application.Interfaces;
using Afisha.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Afisha.Application.EventCategories.Commands.CreateEventCategory
{
    public class CreateEventCategoryCommandHandler
        : IRequestHandler<CreateEventCategoryCommand, Guid>
    {
        private readonly IAfishaDbContext _dbContext;
        public CreateEventCategoryCommandHandler(IAfishaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateEventCategoryCommand request, CancellationToken cancellationToken)
        {
            var client = new EventCategory
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };

            await _dbContext.EventCategories.AddAsync(client, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return client.Id;
        }
    }
}
