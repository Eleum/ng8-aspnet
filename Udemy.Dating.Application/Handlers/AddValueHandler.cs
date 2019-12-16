using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Udemy.Dating.Application.Commands;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Handlers
{
    class AddValueHandler : IRequestHandler<AddValueCommand, Value>
    {
        private readonly IDatingContext _context;

        public AddValueHandler(IDatingContext context)
        {
            _context = context;
        }

        public async Task<Value> Handle(AddValueCommand request, CancellationToken cancellationToken)
        {
            var result = await _context.Values.AddAsync(request.Value);
            _context.SaveChanges();

            return result.Entity;
        }
    }
}
