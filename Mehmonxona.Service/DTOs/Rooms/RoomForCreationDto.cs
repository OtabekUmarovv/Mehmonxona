using Mehmonxona.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Service.DTOs.Rooms
{
    public class RoomForCreationDto
    {
        [Required, MaxLength(64)]
        public string Sign { get; set; }

        [Required]
        public RoomType Type { get; set; }

        public RoomStatus Status { get; set; }
    }
}
