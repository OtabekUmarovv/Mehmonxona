using Mehmonxona.Domain.Enums;

namespace Mehmonxona.Service.DTOs.Orders
{
    public class PaymentForViewModel
    {
        public long Id { get; set; }
        public PaymentType Type { get; set; }
        public decimal Amount { get; set; }
        public OrderForViewModel Order { get; set; }
        public object Client { get; internal set; }
    }
}
