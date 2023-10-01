using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class SecretMessage
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string Budid { get; set; } = null!;
        public long MsgSeq { get; set; }
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string? Imdata { get; set; }
        public string? LastMessage { get; set; }
        public string? CipherText { get; set; }
        public long MessageState { get; set; }
        public long MessageType { get; set; }
        public string? ImdataType { get; set; }
        public long? Timestamp { get; set; }
        public long? SenderTimestampNano { get; set; }
        public string MsgId { get; set; } = null!;
        public long MessageRead { get; set; }
        public long MessagePlayed { get; set; }
        public string AttachmentEncryptedPath { get; set; } = null!;
        public string AttachmentDownloadPath { get; set; } = null!;
    }
}
