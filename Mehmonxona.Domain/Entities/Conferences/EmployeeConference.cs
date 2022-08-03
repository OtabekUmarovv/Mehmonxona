using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Employees;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mehmonxona.Domain.Entities.Conferences
{
    public class EmployeeConference : Auditable
    {
        public long EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public long ConferenceId { get; set; }

        [ForeignKey("ConferenceId")]
        public Conference Conference { get; set; }

    }
}
