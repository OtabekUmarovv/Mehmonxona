using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Service.DTOs.Conferences
{
    public class CanferenceForCreationDto
    {
        [Required]
        public DateTime Time { get; set; }
        
        [Required]
        public long Room_id { get; set; }

    }
}
