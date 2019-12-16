using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Commands
{
    public class AddValueCommand : IRequest<Value>
    {
        public Value Value { get; set; }

        public AddValueCommand(Value value)
        {
            Value = value;
        }
    }
}
