using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Customer name can't be empty.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Customer name must be over 3 characters.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not a valid email address.");
        }
    }
}
