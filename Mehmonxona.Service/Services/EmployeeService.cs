using Mapster;
using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using Mehmonxona.Data.Repositories;
using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.DTOs.Orders;
using Mehmonxona.Service.Extensions;
using Mehmonxona.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mehmonxona.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TypeAdapterConfig config;

        public EmployeeService(MehmonxonaDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);

            config = new TypeAdapterConfig();
            config.NewConfig<Employee, EmployeeForViewModel>()
                .Map(dest => dest.Orders, src => src.Adapt<IEnumerable<OrderForViewModel>>());

        }
        public async Task<EmployeeForViewModel> CreateAsync(EmployeeForCreationDto employeeForCreation)
        {
            var exist = await _unitOfWork.Employees.GetAsync(p => p.Email == employeeForCreation.Email);

            if (exist is not null && exist.State != ItemState.Deleted)
                throw new Exception("Employee allready exist!");

            employeeForCreation.Password = employeeForCreation.Password.HashPassword();

            var newEmployee = employeeForCreation.Adapt<Employee>();

            newEmployee.Create();

            newEmployee = await _unitOfWork.Employees.CreateAsync(newEmployee);

            await _unitOfWork.SaveChangesAsync();

            return newEmployee.Adapt<EmployeeForViewModel>(config);
        }

        public async Task<bool> DeleteAsync(Expression<Func<Employee, bool>> expression)
        {
            var exist = await _unitOfWork.Employees.GetAsync(expression);

            if (exist is null)
                return false;

            exist.Delete();

            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<EmployeeForViewModel>> GetAllAsync(Expression<Func<Employee, bool>> expression = null,
                Tuple<int, int> pagination = null)
        {
            var exist = _unitOfWork.Employees.GetAll(expression)
                .Where(p => p.State != ItemState.Deleted)
                    .GetWithPagination(pagination);

            return exist.Adapt<IEnumerable<EmployeeForViewModel>>(config);
        }

        public async Task<EmployeeForViewModel> GetAsync(Expression<Func<Employee, bool>> expression)
        {
            var exist = await _unitOfWork.Employees.GetAsync(expression);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Employee not found!");

            return exist.Adapt<EmployeeForViewModel>(config);
        }

        public async Task<EmployeeForViewModel> UpdateAsync(long id, EmployeeForCreationDto EmployeeForCreation)
        {
            var exist = await _unitOfWork.Employees.GetAsync(p => p.Id == id);

            if (exist is null || exist.State == ItemState.Deleted)
                throw new Exception("Employee not found!");

            var newEmployee = EmployeeForCreation.Adapt(exist);

            newEmployee.Update();

            newEmployee = _unitOfWork.Employees.Update(newEmployee);

            await _unitOfWork.SaveChangesAsync();

            return newEmployee.Adapt<EmployeeForViewModel>(config);
        }
    }
}
