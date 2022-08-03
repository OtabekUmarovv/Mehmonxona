using Mehmonxona.Domain.Entities.Orders;
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
        Task<Payment> CreateAsync(RoomForCreationDto roomForCreation);
        Task<Payment> UpdateAsync(long id, RoomForCreationDto roomForCreation);
        Task<Payment> DeleteAsync(Expression<Func<Payment, bool>> expressions);
        Task<Payment> GetAsync(Expression<Func<Payment, bool>> expression);
        Task<IEnumerable<Payment>> GetAllAsync(Expression<Func<Payment, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
