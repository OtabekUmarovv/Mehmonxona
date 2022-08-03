using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.DTOs.Orders
{
    public class PaymentForViewModel
    {
        public long Id { get; set; }
        public PaymentType Type { get; set; }
        public decimal Amount { get; set; }
        public OrderForViewModel Order { get; set; }
    }
}
