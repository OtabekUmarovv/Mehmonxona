using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Service.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeForViewModel> CreateAsync(EmployeeForCreationDto roomForCreation);
        Task<EmployeeForViewModel> UpdateAsync(long id, EmployeeForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Employee, bool>> expressions);
        Task<EmployeeForViewModel> GetAsync(Expression<Func<Employee, bool>> expression);
        Task<IEnumerable<EmployeeForViewModel>> GetAllAsync(Expression<Func<Employee, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
