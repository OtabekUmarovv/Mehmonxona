using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Orders;

namespace Mehmonxona.Data.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
