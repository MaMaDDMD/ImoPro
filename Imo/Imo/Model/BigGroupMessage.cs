using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class BigGroupMessage
    {
        public long Id { get; set; }
        public string Bgid { get; set; } = null!;
        public string AnonId { get; set; } = null!;
        public long MsgSeq { get; set; }
        public long? AtMe { get; set; }
        public string? BubbleId { get; set; }
        public string? UserIcon { get; set; }
        public string? UserNickname { get; set; }
        public string? Imdata { get; set; }
        public string? LastMessage { get; set; }
        public long MessageState { get; set; }
        public long MessageType { get; set; }
        public string? ImdataType { get; set; }
        public long? Timestamp { get; set; }
        public string? UserRole { get; set; }
        public long? ActiveTime { get; set; }
        public string? MsgId { get; set; }
        public string? MessageTranslationInfo { get; set; }
    }
}
