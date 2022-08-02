
using Mehmonxona.Domain.Enums;
using System;

namespace Mehmonxona.Service.DTOs.Employees
{
    public class EmployeeForCreation
    {
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
    }
}
