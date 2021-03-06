﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Udemy.Dating.Application.Interfaces;
using Udemy.Dating.Application.Queries;
using Udemy.Dating.Domain;

namespace Udemy.Dating.Application.Handlers
{
    public class GetAllValuesHandler : IRequestHandler<GetAllValuesQuery, List<Value>>
    {
        private readonly IDatingContext _context;

        public GetAllValuesHandler(IDatingContext context)
        {
            _context = context;
        }

        public async Task<List<Value>> Handle(GetAllValuesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Values.ToListAsync();
        }
    }
}
