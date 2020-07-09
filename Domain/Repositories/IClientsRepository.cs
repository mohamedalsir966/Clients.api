using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface IClientsRepository
    {
         Task<IEnumerable<client>> ListAsync();
         Task AddAsync(client client);
         //update ploke
         // Task<Category> FindByIdAsync(int id);
         // void  Update(Category category);
        //  void Remove(Category category);
    }
    
    
}