using Mehmonxona.Domain.Entities.Rooms;
using Mehmonxona.Service.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IRoomService
    {
        Task<RoomForViewModel> CreateAsync(RoomForCreationDto roomForCreation);
        Task<RoomForViewModel> UpdateAsync(long id, RoomForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Room, bool>> expression);
        Task<RoomForViewModel> GetAsync(Expression<Func<Room, bool>> expression);
        Task<IEnumerable<RoomForViewModel>> GetAllAsync(Expression<Func<Room, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
