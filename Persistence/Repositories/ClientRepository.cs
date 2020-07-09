
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public class ClientRepository : BBaseRepositoryclient, IClientsRepository
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<client>> ListAsync()
        {
            return await _context.client.ToListAsync();
        }
         public async Task AddAsync(client client)
        {
            await _context.client.AddAsync(client);
        }
      
    }
}