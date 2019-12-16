using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Udemy.Dating.Application.Commands;

namespace Udemy.Dating.Application.Validation
{
    public class AddValueCommandValidator : AbstractValidator<AddValueCommand>
    {
        public AddValueCommandValidator()
        {
            RuleFor(x => x.Value.Id).NotNull();
            RuleFor(x => int.Parse(x.Value.Name)).GreaterThan(5);
        }
    }
}
