using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class DeeplinkPush
    {
        public string SeqId { get; set; } = null!;
        public string? MsgType { get; set; }
        public string? ContentId { get; set; }
        public long? Timestamp { get; set; }
        public long Clicked { get; set; }
    }
}
