using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Entities.Employees
{
    public class Employee : Auditable
    {
        [MaxLength(64)]
        public string FirstName { get; set; }
        [MaxLength(64)]
        public string LastName { get; set; }
        [MaxLength(16)]
        public string Phone { get; set; }
        [MaxLength(64)]
        public string Email { get; set; }
        [MaxLength(16)]
        public string Passport { get; set; }
        public Gender Gender { get; set; }
        [MaxLength(128)]
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Department Department { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
