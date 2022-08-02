using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
    }
}
