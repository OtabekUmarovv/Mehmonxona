using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Conferences;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.Extensions;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TypeAdapterConfig config;

        public ClientService(MehmonxonaDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);

            config = new TypeAdapterConfig();
            config.NewConfig<Client, ClientForViewModel>()
                .Map(dest => dest.Conferences, src => src.Adapt<IEnumerable<ConferenceForViewModel>>())
                .Map(dest => dest.Orders, src => src.Adapt<IEnumerable<OrderForViewModel>>());

        }
        public async Task<ClientForViewModel> CreateAsync(ClientForCreationDto ClientForCreation)
        {
            var exist = await _unitOfWork.Clients.GetAsync(p => p.Email == ClientForCreation.Email);

            if (exist is not null && exist.State != ItemState.Deleted)
                throw new Exception("Client allready exist!");

            var newClient = ClientForCreation.Adapt<Client>();

            newClient.Create();

            newClient = await _unitOfWork.Clients.CreateAsync(newClient);

            await _unitOfWork.SaveChangesAsync();

            return newClient.Adapt<ClientForViewModel>(config);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Client, bool>> expression)
        {
            var exist = await _unitOfWork.Clients.GetAsync(expression);

            if (exist is null)
                return false;

            exist.Delete();

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ClientForViewModel>> GetAllAsync(Expression<Func<Client, bool>> expression = null,
                Tuple<int, int> pagination = null)
        {
            var exist = _unitOfWork.Clients.GetAll(expression)
                .Where(p => p.State != ItemState.Deleted)
                    .GetWithPagination(pagination);

            return exist.Adapt<IEnumerable<ClientForViewModel>>(config);
        }

        public async Task<ClientForViewModel> GetAsync(Expression<Func<Client, bool>> expression)
        {
            var exist = await _unitOfWork.Clients.GetAsync(expression);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Client not found!");

            return exist.Adapt<ClientForViewModel>(config);
        }

        public async Task<ClientForViewModel> UpdateAsync(long id, ClientForCreationDto ClientForCreation)
        {
            var exist = await _unitOfWork.Clients.GetAsync(p => p.Id == id);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Client not found!");

            var newClient = ClientForCreation.Adapt<Client>();

            newClient.Update();

            newClient = _unitOfWork.Clients.Update(newClient);

            await _unitOfWork.SaveChangesAsync();

            return newClient.Adapt<ClientForViewModel>(config);
        }
    }
}
