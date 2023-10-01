using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ChatHistoryMsg
    {
        public string ConvId { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string? Icon { get; set; }
        public long TimestampNano { get; set; }
        public string? Msg { get; set; }
        public string? Imdata { get; set; }
        public long MsgSeq { get; set; }
    }
}
