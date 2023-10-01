using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Post
    {
        public long Id { get; set; }
        public string PostId { get; set; } = null!;
        public string ChannelId { get; set; } = null!;
        public string? ChannelType { get; set; }
        public string? Icon { get; set; }
        public string Display { get; set; } = null!;
        public string PostType { get; set; } = null!;
        public long Timestamp { get; set; }
        public long TimestampNano { get; set; }
        public long? State { get; set; }
        public string? PostInfo { get; set; }
        public long? Fake { get; set; }
        public long? MessageType { get; set; }
        public long? NewState { get; set; }
        public string? CertificationId { get; set; }
        public long? SendState { get; set; }
        public long? IsAck { get; set; }
        public long? IsPlayed { get; set; }
        public string? LogInfo { get; set; }
    }
}
