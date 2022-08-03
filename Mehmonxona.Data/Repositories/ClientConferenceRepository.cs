using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Conferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Data.Repositories
{
    public class ClientConferenceRepository : GenericRepository<ClientConference>, IClientConferenceRepository
    {
        public ClientConferenceRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
