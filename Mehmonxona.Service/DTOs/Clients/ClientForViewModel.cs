using Mehmonxona.Domain.Enums;
using Mehmonxona.Service.DTOs.Conferences;
using Mehmonxona.Service.DTOs.Orders;
using System.Collections.Generic;

namespace Mehmonxona.Service.DTOs.Clients
{
    public class ClientForViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Passport { get; set; }
        public Gender Gender { get; set; }

        public string Password { get; set; }
        public virtual ICollection<ConferenceForViewModel> Conferences { get; set; }
        public virtual ICollection<OrderForViewModel> Orders { get; set; }
    }
}
