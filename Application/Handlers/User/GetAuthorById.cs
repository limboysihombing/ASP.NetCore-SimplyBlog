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
    public class GetAuthorById
    {
        public class GetUsersQuery : IRequest<Author> {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<GetUsersQuery, Author>
        {
            private readonly IBlogDbContext dbContext;

            public Handler(IBlogDbContext dbContext)
            {
                this.dbContext = dbContext;

            }

            public async Task<Author> Handle(GetUsersQuery request, CancellationToken cancellationToken)
            {
                var res = await dbContext.Author.FirstOrDefaultAsync(x => x.Id == request.Id);
                return res == null ? null : res;
            }
        }
    }
}
