using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Domain.Entities.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Entities.Conferences
{
    public class Conference : Auditable
    {
        public DateTime Time { get; set; }
        public long Room_id { get; set; }
        public Room Room { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
