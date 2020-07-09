
using System.Threading.Tasks;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public class clientUnitOfWork : ICLIENTUnitOfWork
    {
        private readonly DataContext _context;

        public clientUnitOfWork(DataContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}