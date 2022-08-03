using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Domain.Entities.Rooms;
using System;
using System.Collections.Generic;

namespace Mehmonxona.Domain.Entities.Conferences
{
    public class Conference : Auditable
    {
        public Conference()
        {
            this.Clients = new List<Client>();
            this.Employees = new List<Employee>();
        }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public long Room_id { get; set; }
        public Room Room { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
