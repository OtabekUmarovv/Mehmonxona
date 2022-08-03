using Mehmonxona.Domain.Enums;

namespace Mehmonxona.Service.DTOs.Rooms
{
    public class RoomForViewModel
    {
        public long Id { get; set; }
        public string Sign { get; set; }

        public RoomType Type { get; set; }

        public RoomStatus Status { get; set; }
    }
}
