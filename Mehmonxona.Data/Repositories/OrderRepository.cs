using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Orders;

namespace Mehmonxona.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
