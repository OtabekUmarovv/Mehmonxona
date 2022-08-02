using Mehmonxona.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona.Domain.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ItemState ItemState { get; set; }


        public void Created()
        {
            CreatedAt = DateTime.UtcNow;
            ItemState = ItemState.Created;
        }
        public void Updated()
        {
            UpdatedAt = DateTime.UtcNow;
            ItemState = ItemState.Updated;
        }
        public void Deleted()
        {
            DeletedAt = DateTime.UtcNow;
            ItemState = ItemState.Deleted;
        }
    }
}
