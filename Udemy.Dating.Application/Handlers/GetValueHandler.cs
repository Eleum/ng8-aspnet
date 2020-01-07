using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Application.Queries;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Handlers
{
    public class GetValueHandler : IRequestHandler<GetValueQuery, Value>
    {
        private readonly IDatingContext _context;

        public GetValueHandler(IDatingContext context)
        {
            _context = context;
        }

        public async Task<Value> Handle(GetValueQuery request, CancellationToken cancellationToken)
        {
            return await _context.Values.FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}
