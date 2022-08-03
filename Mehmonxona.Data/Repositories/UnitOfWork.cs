using Mehmonxona.Data.Contexts;
using Mehmonxona.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace Mehmonxona.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRoomRepository Rooms { get; }

        public IOrderRepository Orders { get; }

        public IClientRepository Clients { get; }

        public IEmployeeRepository Employees { get; }

        public IConferenceRepository Conferences { get; }

        public IPaymentRepository Payments { get; }

        public IEmployeeConferenceRepository EmployeeConferences { get; }

        public IClientConferenceRepository ClientConferences { get; }

        private readonly MehmonxonaDbContext _dbContext;

        public UnitOfWork(MehmonxonaDbContext dbContext)
        {
            this.Rooms = new RoomRepository(dbContext);
            this.Orders = new OrderRepository(dbContext);
            this.Clients = new ClientRepository(dbContext);
            this.Employees = new EmployeeRepository(dbContext);
            this.Conferences = new ConferenceRepository(dbContext);
            this.Payments = new PaymentRepository(dbContext);
            this.ClientConferences = new ClientConferenceRepository(dbContext);
            this.EmployeeConferences = new EmployeeConferenceRepository(dbContext);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}
