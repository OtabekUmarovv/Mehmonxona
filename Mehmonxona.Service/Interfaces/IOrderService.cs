using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Service.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IOrderService
    {
        Task<Order> CreateAsync(OrderForCreationDto roomForCreation);
        Task<Order> UpdateAsync(long id, OrderForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Order, bool>> expressions);
        Task<Order> GetAsync(Expression<Func<Order, bool>> expression);
        Task<IEnumerable<Order>> GetAllAsync(Expression<Func<Order, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
