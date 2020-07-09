using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;
using Supermarket.API.Resources;
using Supermarket.API.Extensions;
using Supermarket.API.Domain.Services.Communication;

namespace Supermarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientsService _clientService;
        private readonly IMapper _mapper;

       public ClientController(IClientsService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet]
         public async Task<IEnumerable<ClientsResource>> GetAllAsync()
        {
            var client = await _clientService .ListAsync();
            var resources = _mapper.Map<IEnumerable<client>, IEnumerable<ClientsResource>>(client);

            return resources;
        }
          [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] ClientsResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var client = _mapper.Map<ClientsResource, client>(resource);
            var result = await _clientService.SaveAsync(client);

            if (!result.Success)
                return BadRequest(result.Message);

            var ClientsResource = _mapper.Map<client, ClientsResource>(result.client);
            return Ok(ClientsResource);
        }
        
}
}