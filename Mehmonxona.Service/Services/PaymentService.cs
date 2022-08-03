using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Domain.Enums;
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
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TypeAdapterConfig config;

        public PaymentService(MehmonxonaDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);

            config = new TypeAdapterConfig();
            config.NewConfig<Payment, PaymentForViewModel>()
                .Map(dest => dest.Order, src => src.Adapt<OrderForViewModel>());
        }

        public async Task<PaymentForViewModel> CreateAsync(PaymentForCreationDto paymentForCreation)
        {
            var exist = await _unitOfWork.Payments.GetAsync(p => p.OrderId == paymentForCreation.OrderId);

            if (exist is not null && exist.State != ItemState.Deleted)
                throw new Exception("Payment allready exist!");

            var newPayment = paymentForCreation.Adapt<Payment>();

            newPayment.Create();

            newPayment = await _unitOfWork.Payments.CreateAsync(newPayment);

            await _unitOfWork.SaveChangesAsync();

            return newPayment.Adapt<PaymentForViewModel>();
        }

        public async Task<bool> DeleteAsync(Expression<Func<Payment, bool>> expression)
        {
            var exist = await _unitOfWork.Payments.GetAsync(expression);

            if (exist is null)
                return false;

            exist.Delete();

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<PaymentForViewModel>> GetAllAsync(Expression<Func<Payment, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            var exist = _unitOfWork.Payments.GetAll(expression)
                .Where(p => p.State != ItemState.Deleted)
                    .GetWithPagination<Payment>(pagination);

            return exist.Adapt<IEnumerable<PaymentForViewModel>>();
        }

        public async Task<PaymentForViewModel> GetAsync(Expression<Func<Payment, bool>> expression)
        {
            var exist = await _unitOfWork.Payments.GetAsync(expression);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Payment not found!");

            return exist.Adapt<PaymentForViewModel>();
        }

        public async Task<PaymentForViewModel> UpdateAsync(long id, PaymentForCreationDto paymentForCreation)
        {
            var exist = await _unitOfWork.Payments.GetAsync(p => p.Id == id);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Payment not found!");

            var newPayment = paymentForCreation.Adapt<Payment>();

            newPayment.Update();

            newPayment = _unitOfWork.Payments.Update(newPayment);

            await _unitOfWork.SaveChangesAsync();

            return newPayment.Adapt<PaymentForViewModel>();
        }
    }
}
