using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class BigGroupMessageTranslation
    {
        public long Id { get; set; }
        public string Bgid { get; set; } = null!;
        public long MsgSeq { get; set; }
        public long? Timestamp { get; set; }
        public string? MsgId { get; set; }
        public string? MessageTranslationInfo { get; set; }
    }
}
