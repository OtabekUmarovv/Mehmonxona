using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Service.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentForViewModel> CreateAsync(PaymentForCreationDto paymentForCreation);
        Task<PaymentForViewModel> UpdateAsync(long id, PaymentForCreationDto paymentForCreation);
        Task<bool> DeleteAsync(Expression<Func<Payment, bool>> expressions);
        Task<PaymentForViewModel> GetAsync(Expression<Func<Payment, bool>> expression);
        Task<IEnumerable<PaymentForViewModel>> GetAllAsync(
            Expression<Func<Payment, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
