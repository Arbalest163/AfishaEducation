using FluentValidation;
using System.Linq;

namespace Afisha.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.Birthday).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
            RuleFor(c => c.PhoneNumber).Must(IsPhoneValid)
                .Length(12)
                .WithMessage("Длина должна быть от {MinLength} до {MaxLength}." +
                            " Текущая длина: {TotalLength}");
        }

        private bool IsPhoneValid(string phone)
        {
            if(phone != null)
            return phone.Substring(1).All(c => char.IsDigit(c));
            return true;
        }
    }
}
