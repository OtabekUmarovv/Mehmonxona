using Mehmonxona.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Service.DTOs.Orders
{
    public class PaymentForCreationDto
    {
        [Required]
        public PaymentType Type { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public long OrderId { get; set; }
    }
}
