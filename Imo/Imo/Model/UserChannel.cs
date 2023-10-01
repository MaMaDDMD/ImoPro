using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class UserChannel
    {
        public long Id { get; set; }
        public string UserChannelId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Icon { get; set; }
        public string? Background { get; set; }
        public long IsDefaultBackground { get; set; }
        public string? ShareId { get; set; }
        public string? CertificationId { get; set; }
        public long? PostMaxSeq { get; set; }
        public string? ChannelStatus { get; set; }
        public string? IsFollowing { get; set; }
        public long IsCollapsible { get; set; }
        public long IsAutoCollapsible { get; set; }
        public long IsMuted { get; set; }
        public long IsShield { get; set; }
        public long FollowTimestamp { get; set; }
        public long UnreadNum { get; set; }
        public long UnreadBroadcastNum { get; set; }
        public long UnreadChatNum { get; set; }
        public long? LastReadTimestamp { get; set; }
        public string? ChannelUserExtend { get; set; }
        public long IsOwner { get; set; }
        public string? Welcome { get; set; }
        public string? InputHint { get; set; }
        public string? ChannelType { get; set; }
        public long? PostLastTime { get; set; }
        public string? Bio { get; set; }
    }
}
