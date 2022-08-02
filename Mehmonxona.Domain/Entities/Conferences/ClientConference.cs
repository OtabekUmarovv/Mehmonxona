using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Clients;
using Mehmonxona.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Entities.Conferences
{
    public class ClientConference : Auditable
    {
        public long ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public long ConferenceId { get; set; }
        [ForeignKey("CoferenceId")]
        public Conference Conference { get; set; }
    }
}
