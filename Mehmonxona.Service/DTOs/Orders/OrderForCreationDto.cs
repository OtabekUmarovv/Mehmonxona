

namespace Mehmonxona.Service.DTOs.Orders
{
    public class OrderForCreationDto
    {
        public long EmployeeId { get; set; }
        public long ClientId { get; set; }
        public long RoomId { get; set; }
        public long PaymentId { get; set; }
    }
}
