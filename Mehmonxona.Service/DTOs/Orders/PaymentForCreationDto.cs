using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
