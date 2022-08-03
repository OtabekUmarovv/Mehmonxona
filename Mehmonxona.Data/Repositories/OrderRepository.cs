using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
