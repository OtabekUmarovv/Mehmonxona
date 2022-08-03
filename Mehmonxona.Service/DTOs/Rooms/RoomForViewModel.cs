using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
