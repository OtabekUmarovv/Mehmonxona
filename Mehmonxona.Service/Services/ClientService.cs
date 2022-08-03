using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class ClientService : IClientService
    {
        public Task<ClientForViewModel> CreateAsync(ClientForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Client, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientForViewModel>> GetAllAsync(Expression<Func<Client, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<ClientForViewModel> GetAsync(Expression<Func<Client, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ClientForViewModel> UpdateAsync(long id, ClientForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }
    }
}
