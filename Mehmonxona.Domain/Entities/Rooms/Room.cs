
using Mehmonxona.Domain.Commons;
using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Entities.Rooms
{
    public class Room : Auditable
    {
        [Required, MaxLength(64)]
        public string Sign { get; set; }
        public RoomType Type { get; set; }
        public RoomStatus Status { get; set; };
    }
}
