using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<EmployeeForViewModel> CreateAsync(EmployeeForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Employee, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeForViewModel>> GetAllAsync(Expression<Func<Employee, bool>> expression = null, Tuple<int, int> pagination = null)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeForViewModel> GetAsync(Expression<Func<Employee, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeForViewModel> UpdateAsync(long id, EmployeeForCreationDto roomForCreation)
        {
            throw new NotImplementedException();
        }
    }
}
