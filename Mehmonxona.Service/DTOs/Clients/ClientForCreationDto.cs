using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.DTOs.Clients
{
    public class ClientForCreationDto
    {
        [Required(AllowEmptyStrings = false), MaxLength(64)]
        public string FirstName { get; set; }
        
        [Required(AllowEmptyStrings = false), MaxLength(64)]
        public string LastName { get; set; }

        [Required, MaxLength(16),Phone]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false), EmailAddress]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Passport { get; set; }
        public Gender Gender { get; set; }
        
        [Required(AllowEmptyStrings = false), MaxLength(64), MinLength(8)]
        public string Password { get; set; }
    }
}
