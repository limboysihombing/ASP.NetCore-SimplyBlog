using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IBlogDbContext
    {
        DbSet<Author> Author { get; set; }
        DbSet<Book> Book { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
