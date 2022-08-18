using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price can't be empty.");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0.");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity can't be empty.");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0.");
            RuleFor(x => x.CustomerId).NotEmpty().WithMessage("Customer ID can't be empty.");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address can't be empty.");
        }
    }
}
