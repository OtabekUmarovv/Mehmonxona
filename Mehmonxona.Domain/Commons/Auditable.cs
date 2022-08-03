using Mehmonxona.Domain.Enums;
using System;

namespace Mehmonxona.Domain.Commons
{
    public abstract class Auditable
    {
        public long Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ItemState State { get; set; }


        public void Create()
        {
            CreatedAt = DateTime.UtcNow;
            State = ItemState.Created;
        }
        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
            State = ItemState.Updated;
        }
        public void Delete()
        {
            DeletedAt = DateTime.UtcNow;
            State = ItemState.Deleted;
        }
    }
}
