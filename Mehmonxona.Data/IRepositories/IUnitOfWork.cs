using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRoomRepository Rooms { get; }
        IOrderRepository Orders { get; }
        IClientRepository Clients { get; }
        IEmployeeRepository Employees { get; }
        IConferenceRepository Conferences { get; }
        IPaymentRepository Payments { get; }
        IEmployeeConferenceRepository EmployeeConferences { get; }
        IClientConferenceRepository ClientConferences { get; }

        Task SaveChangesAsync();
    }
}
