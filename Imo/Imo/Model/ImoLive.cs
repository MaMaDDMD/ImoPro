using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ImoLive
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public byte[] RoomId { get; set; } = null!;
        public byte[] LastUpdateTime { get; set; } = null!;
    }
}
