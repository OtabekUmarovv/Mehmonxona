using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Service.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee> CreateAsync(EmployeeForCreationDto roomForCreation);
        Task<Employee> UpdateAsync(long id, EmployeeForCreationDto roomForCreation);
        Task<bool> DeleteAsync(Expression<Func<Employee, bool>> expressions);
        Task<Employee> GetAsync(Expression<Func<Employee, bool>> expression);
        Task<IEnumerable<Employee>> GetAllAsync(Expression<Func<Employee, bool>>? expression = null, Tuple<int, int>? pagination = null);
    }
}
