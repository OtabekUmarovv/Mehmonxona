
using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mehmonxona.Domain.Entities.Rooms
{
    public class Room : Auditable
    {
        [MaxLength(64)]
        public string Sign { get; set; }
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Free;
    }
}
