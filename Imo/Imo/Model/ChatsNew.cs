using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ChatsNew
    {
        public long Id { get; set; }
        public string ChatType { get; set; } = null!;
        public long RowType { get; set; }
        public string? ChannelType { get; set; }
        public string Buid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Icon { get; set; }
        public string? LastMessage { get; set; }
        public long? HasUnreadAtMessage { get; set; }
        public long Timestamp { get; set; }
        public long ActiveTimestamp { get; set; }
        public long StickyTopTimestamp { get; set; }
        public string? RelationChatSourceType { get; set; }
        public long IsFolded { get; set; }
        public long? IsPrivate { get; set; }
        public long? IsInvisibleFriend { get; set; }
        public string? AnonId { get; set; }
        public long? LastMessageType { get; set; }
    }
}
