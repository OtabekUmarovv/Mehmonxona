using Mehmonxona.Domain.Enums;


namespace Mehmonxona.Service.DTOs.Orders
{
    public class PaymentForCreationDto
    {
        public PaymentType Type { get; set; }
        public decimal Amount { get; set; }
        public long OrderId { get; set; }
    }
}
