using Mehmonxona.Service.DTOs.Clients;
using Mehmonxona.Service.DTOs.Employees;
using Mehmonxona.Service.DTOs.Rooms;

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
