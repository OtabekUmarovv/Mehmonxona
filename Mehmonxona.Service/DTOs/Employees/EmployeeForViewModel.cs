using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.DTOs.Employees
{
    public class EmployeeForViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Passport { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Department Department { get; set; }
        public ICollection<OrderForViewModel> Orders { get; set; }
    }
}
