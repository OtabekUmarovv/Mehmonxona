using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Clients;

namespace Mehmonxona.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
