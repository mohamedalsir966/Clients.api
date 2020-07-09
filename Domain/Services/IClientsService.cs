using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services.Communication;

namespace Supermarket.API.Domain.Services
{
    public interface IClientsService
    {
        Task<IEnumerable<client>> ListAsync();
        Task<SaveClientResponse> SaveAsync(client client);
       // Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
       // Task<SaveCategoryResponse> DeleteAsync(int id);
        
    }
}