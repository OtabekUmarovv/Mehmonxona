using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Entities.Conferences
{
    public class EmployeeConference : Auditable
    {
        public long EmployeeId { get; set; }
        
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public long ConferenceId { get; set; }
        public Conference Conference { get; set; }

    }
}
