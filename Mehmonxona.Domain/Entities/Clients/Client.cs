using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Conferences;
using Mehmonxona.Domain.Entities.Orders;
using Mehmonxona.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Domain.Entities.Clients
{
    public class Client : Auditable
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
        public string Password { get; set; }
        public ICollection<Conference> Conferences { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
