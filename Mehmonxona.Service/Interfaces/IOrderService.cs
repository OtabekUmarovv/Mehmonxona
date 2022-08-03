using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Service.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IOrderService
    {
        Task<OrderForViewModel> CreateAsync(OrderForCreationDto roomForCreation);
        Task<OrderForViewModel> UpdateAsync(long id, OrderForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Order, bool>> expressions);
        Task<OrderForViewModel> GetAsync(Expression<Func<Order, bool>> expression);
        Task<IEnumerable<OrderForViewModel>> GetAllAsync(Expression<Func<Order, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
