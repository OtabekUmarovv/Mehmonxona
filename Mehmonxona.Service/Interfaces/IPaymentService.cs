using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentForViewModel> CreateAsync(RoomForCreationDto roomForCreation);
        Task<PaymentForViewModel> UpdateAsync(long id, RoomForCreationDto roomForCreation);
        Task<PaymentForViewModel> DeleteAsync(Expression<Func<Payment, bool>> expressions);
        Task<PaymentForViewModel> GetAsync(Expression<Func<Payment, bool>> expression);
        Task<IEnumerable<PaymentForViewModel>> GetAllAsync(Expression<Func<Payment, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
