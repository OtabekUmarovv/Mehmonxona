using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Rooms;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Extensions;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
#pragma warning disable CS1998
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

            newRoom.Create();

            newRoom = await _unitOfWork.Rooms.CreateAsync(newRoom);

            await _unitOfWork.SaveChangesAsync();

            return newRoom.Adapt<RoomForViewModel>();
        }

        public async Task<bool> DeleteAsync(Expression<Func<Room, bool>> expression)
        {
            var exist = await _unitOfWork.Rooms.GetAsync(expression);

            if (exist is null)
                return false;

            exist.Delete();

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<RoomForViewModel>> GetAllAsync(Expression<Func<Room, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            var exist = _unitOfWork.Rooms.GetAll(expression)
                .Where(p => p.State != ItemState.Deleted)
                    .GetWithPagination(pagination);

            return exist.Adapt<IEnumerable<RoomForViewModel>>();
        }

        public async Task<RoomForViewModel> GetAsync(Expression<Func<Room, bool>> expression)
        {
            var exist = await _unitOfWork.Rooms.GetAsync(expression);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Room not found!");

            return exist.Adapt<RoomForViewModel>();
        }

        public async Task<RoomForViewModel> UpdateAsync(long id, RoomForCreationDto roomForCreation)
        {
            var exist = await _unitOfWork.Rooms.GetAsync(p => p.Id == id);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Room not found!");

            exist = roomForCreation.Adapt(exist);

            exist.Update();

            exist = _unitOfWork.Rooms.Update(exist);

            await _unitOfWork.SaveChangesAsync();

            return exist.Adapt<RoomForViewModel>();
        }
    }
}
