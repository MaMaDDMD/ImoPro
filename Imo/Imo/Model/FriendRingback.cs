using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class FriendRingback
    {
        public string Buid { get; set; } = null!;
        public string ToneId { get; set; } = null!;
        public string? Data { get; set; }
        public long? Uptime { get; set; }
    }
}
