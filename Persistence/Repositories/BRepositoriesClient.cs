using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public abstract class BBaseRepositoryclient
    {
        protected readonly DataContext _context;

        public BBaseRepositoryclient(DataContext context)
        {
            _context = context;
        }
    }
}