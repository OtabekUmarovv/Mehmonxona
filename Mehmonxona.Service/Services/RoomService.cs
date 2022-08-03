using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Rooms;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomService(MehmonxonaDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);
        }

        public async Task<RoomForViewModel> CreateAsync(RoomForCreationDto roomForCreation)
        {
            var exist = await _unitOfWork.Rooms.GetAsync(p => p.Sign == roomForCreation.Sign);

            if (exist is not null && exist.State != ItemState.Deleted)
                throw new Exception("Room allready exist!");

            var newRoom = roomForCreation.Adapt<Room>(); 

            newRoo
        }

        public Task<bool> DeleteAsync(Expression<Func<Room, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> GetAllAsync(Expression<Func<Room, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetAsync(Expression<Func<Room, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Room> UpdateAsync(long id, RoomForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }
    }
}
