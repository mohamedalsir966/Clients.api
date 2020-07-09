using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;
using Supermarket.API.Domain.Services.Communication;
using System;
namespace Supermarket.API.Services
{
    public class ClientService : IClientsService
    {
        private readonly IClientsRepository _ClientRepository;
       private readonly ICLIENTUnitOfWork _unitOfWork;

        public ClientService(IClientsRepository ClientRepository, ICLIENTUnitOfWork unitOfWork)
        {
            _ClientRepository = ClientRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<client>> ListAsync()
        {
            return await _ClientRepository .ListAsync();
        }
         public async Task<SaveClientResponse> SaveAsync(client client)
        {
            try
            {
                await _ClientRepository.AddAsync(client);
                await _unitOfWork.CompleteAsync();

                return new SaveClientResponse(client);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SaveClientResponse($"An error occurred when saving the client: {ex.Message}");
            }
        }

       


    }
}