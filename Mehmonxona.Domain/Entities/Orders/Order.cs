using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Entities.Employees;
using Mehmonxona.Domain.Entities.Rooms;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mehmonxona.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public long EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public long ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public long RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public long PaymentId { get; set; }
        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }
    }
}
