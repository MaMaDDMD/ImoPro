using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class RelationshipMessage
    {
        public long Id { get; set; }
        public string RelId { get; set; } = null!;
        public string? Author { get; set; }
        public string? LastMessage { get; set; }
        public string? ImdataType { get; set; }
        public string? Imdata { get; set; }
        public long Timestamp { get; set; }
        public long MsgSeq { get; set; }
        public long IsSilent { get; set; }
        public long MessageType { get; set; }
        public long MessageState { get; set; }
        public long MessageRead { get; set; }
        public string? MessageTranslationInfo { get; set; }
    }
}
