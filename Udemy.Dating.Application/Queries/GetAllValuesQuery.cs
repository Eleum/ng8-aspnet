using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Queries
{
    public class GetAllValuesQuery : IRequest<List<Value>>
    {

    }
}
