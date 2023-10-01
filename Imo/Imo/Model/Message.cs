using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Message
    {
        public long Id { get; set; }
        public long ViewType { get; set; }
        public string Buid { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Icon { get; set; }
        public string? Author { get; set; }
        public string? AuthorAlias { get; set; }
        public string? AuthorIcon { get; set; }
        public string? Imdata { get; set; }
        public string? LastMessage { get; set; }
        public long? Timestamp { get; set; }
        public long? MessageIndex { get; set; }
        public long MessageType { get; set; }
        public long MessageState { get; set; }
        public long MessageRead { get; set; }
        public long? NumTries { get; set; }
        public long? MessagePlayed { get; set; }
        public byte[] SeqNumber { get; set; } = null!;
        public byte[]? PreTs { get; set; }
        public long? MsgCheckStatus { get; set; }
        public long ClickNumTries { get; set; }
        public byte[] SenderTimestampNano { get; set; } = null!;
        public string? MsgId { get; set; }
        public string? GroupMsgId { get; set; }
        public string? MessageTranslationInfo { get; set; }
        public long DeleteType { get; set; }
        public byte[] ExpirationTimestamp { get; set; } = null!;
        public byte[] TsOpenTimeMachine { get; set; } = null!;
        public long MsgNeedFiltered { get; set; }
        public long EncryptFlag { get; set; }
    }
}
