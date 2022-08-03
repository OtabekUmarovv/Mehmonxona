using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<PaymentForViewModel> CreateAsync(RoomForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentForViewModel> DeleteAsync(Expression<Func<Payment, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentForViewModel>> GetAllAsync(Expression<Func<Payment, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentForViewModel> GetAsync(Expression<Func<Payment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentForViewModel> UpdateAsync(long id, RoomForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }
    }
}
