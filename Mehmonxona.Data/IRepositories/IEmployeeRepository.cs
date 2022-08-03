using Mehmonxona.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Data.IRepositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}
