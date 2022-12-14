using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Conferences;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Conferences;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.DTOs.Rooms;
using Mehmonxona.Service.Extensions;
using Mehmonxona.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class ConferenceService : IConferenceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TypeAdapterConfig config;

        public ConferenceService(MehmonxonaDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);

            config = new TypeAdapterConfig();
            config.NewConfig<Conference, ConferenceForViewModel>()
                .Map(dest => dest.Room, src => src.Adapt<RoomForViewModel>())
                .Map(dest => dest.Clients, src => src.Adapt<IEnumerable<ClientForViewModel>>())
                .Map(dest => dest.Employees, src => src.Adapt<ICollection<EmployeeForViewModel>>());

        }
        public async Task<ConferenceForViewModel> CreateAsync(ConferenceForCreationDto conferenceForCreation)
        {
            var exist = await _unitOfWork.Conferences.GetAsync(p => p.Name == conferenceForCreation.Name);

            if (exist is not null && exist.State != ItemState.Deleted)
                throw new Exception("Conference allready exist!");

            var newConference = conferenceForCreation.Adapt<Conference>();

            newConference.Create();

            newConference = await _unitOfWork.Conferences.CreateAsync(newConference);

            await _unitOfWork.SaveChangesAsync();

            return newConference.Adapt<ConferenceForViewModel>(config);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Conference, bool>> expression)
        {
            var exist = await _unitOfWork.Conferences.GetAsync(expression);

            if (exist is null)
                return false;

            exist.Delete();

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ConferenceForViewModel>> GetAllAsync(Expression<Func<Conference, bool>> expression = null,
                Tuple<int, int> pagination = null)
        {
            var exist = _unitOfWork.Conferences.GetAll(expression)
                .GetWithPagination(pagination)
                    .Include(confer => confer.Clients)
                        .Include(confer => confer.Employees)
                            .Include(confer => confer.Room)
                                .Where(p => p.State != ItemState.Deleted)
                                    .Adapt<IEnumerable<ConferenceForViewModel>>(config);

            return exist;
        }

        public async Task<ConferenceForViewModel> GetAsync(Expression<Func<Conference, bool>> expression)
        {
            var exist = await _unitOfWork.Conferences.GetAsync(expression);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Conference not found!");

            return exist.Adapt<ConferenceForViewModel>(config);
        }

        public async Task<ConferenceForViewModel> UpdateAsync(long id, ConferenceForCreationDto conferenceForCreation)
        {
            var exist = await _unitOfWork.Conferences.GetAsync(p => p.Id == id);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Conference not found!");

            var newConference = conferenceForCreation.Adapt(exist);

            newConference.Update();

            newConference = _unitOfWork.Conferences.Update(newConference);

            await _unitOfWork.SaveChangesAsync();

            return newConference.Adapt<ConferenceForViewModel>(config);
        }

    }
}
