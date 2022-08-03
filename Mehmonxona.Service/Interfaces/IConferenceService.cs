﻿using Mehmonxona.Domain.Entities.Conferences;
using Mehmonxona.Service.DTOs.Conferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IConferenceService
    {
        Task<Conference> CreateAsync(ConferenceForCreationDto roomForCreation);
        Task<Conference> UpdateAsync(long id, ConferenceForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Conference, bool>> expressions);
        Task<Conference> GetAsync(Expression<Func<Conference, bool>> expression);
        Task<IEnumerable<Conference>> GetAllAsync(Expression<Func<Conference, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}