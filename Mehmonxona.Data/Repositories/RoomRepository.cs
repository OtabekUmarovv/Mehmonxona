using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Domain.Entities.Rooms;

namespace Mehmonxona.Data.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(MehmonxonaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
