using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Queries
{
    public class GetValueQuery : IRequest<Value>
    {
        public int Id { get; }

        public GetValueQuery(int id)
        {
            Id = id;
        }
    }
}
