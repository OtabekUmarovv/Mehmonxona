using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class OrderService : IOrderService
    {
        public Task<OrderForViewModel> CreateAsync(OrderForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Order, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderForViewModel>> GetAllAsync(Expression<Func<Order, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderForViewModel> GetAsync(Expression<Func<Order, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<OrderForViewModel> UpdateAsync(long id, OrderForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }
    }
}
