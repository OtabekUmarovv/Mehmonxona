using AutoMapper;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Rooms;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Interfaces;
using Mehmonxona.Service.Mappers;
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
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uniOfWork;

        public RoomService(MehmonxonaDbContext dbContext)
        {
            _uniOfWork = new UnitOfWork(dbContext);

            this._mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
        }

        public async Task<Room> CreateAsync(RoomForCreationDto roomForCreation)
        {
            var exist = await _uniOfWork.Rooms.GetAsync(p => p.Sign == roomForCreation.Sign && p.State != ItemState.Deleted);

            if (exist is null)
                throw new Exception("Room already exist!");

            return null;
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
