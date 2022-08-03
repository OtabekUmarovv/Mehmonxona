using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Conferences;

namespace Mehmonxona.Data.Repositories
{
    public class EmployeeConferenceRepository : GenericRepository<EmployeeConference>, IEmployeeConferenceRepository
    {
        public EmployeeConferenceRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
