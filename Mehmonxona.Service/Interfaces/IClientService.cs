using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Service.DTOs.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IClientService
    {
        Task<ClientForCreationDto> CreateAsync(ClientForCreationDto roomForCreation);
        Task<ClientForCreationDto> UpdateAsync(long id, ClientForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Client, bool>> expressions);
        Task<ClientForCreationDto> GetAsync(Expression<Func<Client, bool>> expression);
        Task<IEnumerable<ClientForCreationDto>> GetAllAsync(Expression<Func<Client, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
