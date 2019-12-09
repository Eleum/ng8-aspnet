using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Udemy.Dating.Application.Queries;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Handlers
{
    public class GetAllValuesHandler : IRequestHandler<GetAllValuesQuery, List<Value>>
    {
        public GetAllValuesHandler()
        {

        }

        public async Task<List<Value>> Handle(GetAllValuesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
