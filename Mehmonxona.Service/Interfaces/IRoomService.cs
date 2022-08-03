using Mehmonxona.Domain.Entities.Rooms;
using Mehmonxona.Service.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IRoomService
    {
        Task<Room> CreateAsync(RoomForCreationDto roomForCreation);
        Task<Room> UpdateAsync(long id, RoomForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Room, bool>> expressions);
        Task<Room> GetAsync(Expression<Func<Room, bool>> expression);
        Task<IEnumerable<Room>> GetAllAsync(Expression<Func<Room, bool>>? expression = null, Tuple<int,int>? pagination = null);
    }
}
