using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Application.EventCategories.Commands.CreateEventCategory
{
    public class CreateEventCategoryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
