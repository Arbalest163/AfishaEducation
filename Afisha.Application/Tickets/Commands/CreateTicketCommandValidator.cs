using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afisha.Application.Tickets.Commands
{
    public class CreateTicketCommandValidator : AbstractValidator<CreateTicketCommand>
    {
        public CreateTicketCommandValidator()
        {
            RuleFor(c => c.Price).NotEmpty().Must(IsPriceValid).WithMessage("Цена не может быть меньше нуля");
        }

        private bool IsPriceValid(uint price)
        {
            if (price < 0)
                return false;
            return true;
        }
    }
}
