using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Conferences;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Extensions;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TypeAdapterConfig config;

        public OrderService(MehmonxonaDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);

            config = new TypeAdapterConfig();
            config.NewConfig<Order, OrderForViewModel>()
                .Map(dest => dest.Client, src => src.Adapt<ClientForViewModel>())
                .Map(desc => desc.Employee, src => src)
                .Map(dest => dest.Room, src => src.Adapt<RoomForViewModel>());

        }
        public async Task<OrderForViewModel> CreateAsync(OrderForCreationDto orderForCreation)
        {
            var exist = await _unitOfWork.Orders.GetAsync(
                p => p.ClientId == orderForCreation.ClientId && 
                    p.EmployeeId == orderForCreation.EmployeeId && p.RoomId == orderForCreation.RoomId);

            if (exist is not null && exist.State != ItemState.Deleted)
                throw new Exception("Order allready exist!");

            var newOrder = orderForCreation.Adapt<Order>();

            newOrder.Create();

            newOrder = await _unitOfWork.Orders.CreateAsync(newOrder);

            await _unitOfWork.SaveChangesAsync();

            return newOrder.Adapt<OrderForViewModel>(config);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Order, bool>> expression)
        {
            var exist = await _unitOfWork.Orders.GetAsync(expression);

            if (exist is null)
                return false;

            exist.Delete();

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<OrderForViewModel>> GetAllAsync(Expression<Func<Order, bool>> expression = null,
                Tuple<int, int> pagination = null)
        {
            var exist = _unitOfWork.Orders.GetAll(expression)
                .Where(p => p.State != ItemState.Deleted)
                    .GetWithPagination(pagination);

            return exist.Adapt<IEnumerable<OrderForViewModel>>(config);
        }

        public async Task<OrderForViewModel> GetAsync(Expression<Func<Order, bool>> expression)
        {
            var exist = await _unitOfWork.Orders.GetAsync(expression);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Order not found!");

            return exist.Adapt<OrderForViewModel>(config);
        }

        public async Task<OrderForViewModel> UpdateAsync(long id, OrderForCreationDto orderForCreation)
        {
            var exist = await _unitOfWork.Orders.GetAsync(p => p.Id == id);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Order not found!");

            var newOrder = orderForCreation.Adapt<Order>();

            newOrder.Update();

            newOrder = _unitOfWork.Orders.Update(newOrder);

            await _unitOfWork.SaveChangesAsync();

            return newOrder.Adapt<OrderForViewModel>(config);
        }
    }
}
