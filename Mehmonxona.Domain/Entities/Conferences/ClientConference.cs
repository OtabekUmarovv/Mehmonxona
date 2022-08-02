using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Clients;
using System.ComponentModel.DataAnnotations.Schema;

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
