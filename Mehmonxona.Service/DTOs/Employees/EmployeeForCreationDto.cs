using Mehmonxona.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Service.DTOs.Employees
{
    public class EmployeeForCreationDto
    {
        [Required(AllowEmptyStrings = false), MaxLength(64)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(64)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(16)]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false), EmailAddress]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(64)]

        public string Passport { get; set; }

        public Gender Gender { get; set; }


        public string Address { get; set; }
        public decimal Salary { get; set; }

        [Required(AllowEmptyStrings = false), MinLength(8), MaxLength(64)]
        public string Password { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Department Department { get; set; }
    }
}
