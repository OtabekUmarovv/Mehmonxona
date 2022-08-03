using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Conferences;

namespace Mehmonxona.Data.Repositories
{
    public class ConferenceRepository : GenericRepository<Conference>, IConferenceRepository
    {
        public ConferenceRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
