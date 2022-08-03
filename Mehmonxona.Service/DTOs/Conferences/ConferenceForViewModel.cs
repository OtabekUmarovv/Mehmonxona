using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.DTOs.Conferences
{
    public class ConferenceForViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public long Room_id { get; set; }
        public RoomForViewModel Room { get; set; }
        public ICollection<ClientForViewModel> Clients { get; set; }
        public ICollection<EmployeeForViewModel> Employees { get; set; }
    }
}
