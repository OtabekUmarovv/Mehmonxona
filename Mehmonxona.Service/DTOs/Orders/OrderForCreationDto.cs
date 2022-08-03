using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Service.DTOs.Orders
{
    public class OrderForCreationDto
    {
        [Required]
        public long EmployeeId { get; set; }

        [Required]
        public long ClientId { get; set; }

        [Required]
        public long RoomId { get; set; }

        [Required]
        public long PaymentId { get; set; }
    }
}
