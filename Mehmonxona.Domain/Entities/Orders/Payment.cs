using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Entities.Orders
{
    public class Payment : Auditable
    {
        public PaymentType Type { get; set; }
        public decimal Amount { get; set; }
        public long OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
