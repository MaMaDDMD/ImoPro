using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class UserChannelPost
    {
        public long Id { get; set; }
        public string UserChannelId { get; set; } = null!;
        public string PostId { get; set; } = null!;
        public long IsMock { get; set; }
        public long? MsgSeq { get; set; }
        public long? Timestamp { get; set; }
        public string? Msg { get; set; }
        public long? PostStatus { get; set; }
        public long? MessageType { get; set; }
        public string? PostType { get; set; }
        public string? PostInfo { get; set; }
        public string? PostSubType { get; set; }
        public string? PageType { get; set; }
        public string? PostExtend { get; set; }
        public string? LogInfo { get; set; }
        public string? ChannelMessageType { get; set; }
        public string? IsAck { get; set; }
        public string? TransInfo { get; set; }
        public string? SendCommandId { get; set; }
        public string? TransAudioToText { get; set; }
        public long? IsReadTransTextToAudio { get; set; }
        public string? TransTextToAudio { get; set; }
    }
}
