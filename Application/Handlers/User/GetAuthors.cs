using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.User
{
    public class GetAuthors
    {
        public class GetUsersQuery : IRequest<List<Author>> { }

        public class Handler : IRequestHandler<GetUsersQuery, List<Author>>
        {
            private readonly IBlogDbContext dbContext;

            public Handler(IBlogDbContext dbContext)
            {
                this.dbContext = dbContext;
                
            }

            public async Task<List<Author>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
            {
                var res = await dbContext.Author.Include(b => b.Book).ToListAsync();
                return res == null ? null : res;
            }
        }
    }
}
