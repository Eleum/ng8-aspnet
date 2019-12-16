using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Udemy.Dating.Application.Queries;

namespace Udemy.Dating.Application.Validation
{
    public class GetValueQueryValidator : AbstractValidator<GetValueQuery>
    {
        public GetValueQueryValidator()
        {
            RuleFor(x => x.Id).Equal(1);
        }
    }
}
