using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Employees;

namespace Mehmonxona.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
