
using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Enums;

namespace Mehmonxona.Domain.Entities.Rooms
{
    public class Room : Auditable
    {
        public string Sign { get; set; }
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Free;
    }
}
