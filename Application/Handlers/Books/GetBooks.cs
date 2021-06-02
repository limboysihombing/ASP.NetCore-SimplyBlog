using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Books
{
    public class GetBooks
    {
        public class Query : IRequest<List<Book>>
        {

        }

        public class Handler : IRequestHandler<Query, List<Book>>
        {
            private readonly IBlogDbContext dbContext;

            public Handler(IBlogDbContext dbContext)
            {
                this.dbContext = dbContext;

            }
            public async Task<List<Book>> Handle(Query request, CancellationToken cancellationToken)
            {
                var a = await dbContext.Book.Include(b => b.Author).ToListAsync();
                return a;
            }
        }
    }
}
