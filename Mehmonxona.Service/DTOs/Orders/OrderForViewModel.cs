using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.DTOs.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.DTOs.Orders
{
    public class OrderForViewModel
    {
        public EmployeeForViewModel Employee { get; set; }

        public ClientForViewModel Client { get; set; }

        public RoomForViewModel Room { get; set; }

        public PaymentForViewModel Payment { get; set; }
    }
}
