
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Entities.Conferences;
using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Domain.Entities.Rooms;
using Microsoft.EntityFrameworkCore;

namespace Mehmonxona.Data.Contexts
{
    public class MehmonxonaDbContext : DbContext
    {
        const string connectionString = "Server=127.0.0.1;Port=5432;Database=Mehmonxona;Username=postgres;Password=1379";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientConference> ClientConferences { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<EmployeeConference> EmployeeConferences { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
