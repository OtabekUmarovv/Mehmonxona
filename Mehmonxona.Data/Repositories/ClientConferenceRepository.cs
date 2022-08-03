using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Conferences;

namespace Mehmonxona.Data.Repositories
{
    public class ClientConferenceRepository : GenericRepository<ClientConference>, IClientConferenceRepository
    {
        public ClientConferenceRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
