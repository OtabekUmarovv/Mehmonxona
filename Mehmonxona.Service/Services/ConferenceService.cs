using Mehmonxona.Domain.Entities.Conferences;
using Mehmonxona.Service.DTOs.Conferences;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class ConferenceService : IConferenceService
    {
        public Task<ConferenceForViewModel> CreateAsync(ConferenceForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Conference, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConferenceForViewModel>> GetAllAsync(Expression<Func<Conference, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<ConferenceForViewModel> GetAsync(Expression<Func<Conference, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ConferenceForViewModel> UpdateAsync(long id, ConferenceForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }
    }
}
