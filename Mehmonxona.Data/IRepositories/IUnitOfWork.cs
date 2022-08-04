using Mehmonxona.Data.Contexts;
using System;
using System.Threading.Tasks;

namespace Mehmonxona.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IRoomRepository Rooms { get; }
        public IOrderRepository Orders { get; }
        public IClientRepository Clients { get; }
        public IEmployeeRepository Employees { get; }
        public IConferenceRepository Conferences { get; }
        public IPaymentRepository Payments { get; }
        public IEmployeeConferenceRepository EmployeeConferences { get; }
        public IClientConferenceRepository ClientConferences { get; }
        public MehmonxonaDbContext _dbContext { get; set; }


        Task SaveChangesAsync();
    }
}
