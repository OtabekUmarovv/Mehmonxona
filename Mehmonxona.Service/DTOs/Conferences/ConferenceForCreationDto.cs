using System;
using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Service.DTOs.Conferences
{
    public class ConferenceForCreationDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime Time { get; set; }

        [Required]
        public long Room_id { get; set; }

    }
}
