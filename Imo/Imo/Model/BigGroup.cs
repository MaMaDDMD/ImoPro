using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class BigGroup
    {
        public long Id { get; set; }
        public string Bgid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long? IsMuted { get; set; }
        public string? Icon { get; set; }
        public long LastMsgSeq { get; set; }
        public long LastReadMsgSeq { get; set; }
        public long NumUnread { get; set; }
        public long ClosedAnnouncementId { get; set; }
        public string? Role { get; set; }
        public byte[] MillsToPromoted { get; set; } = null!;
        public string? ShortId { get; set; }
        public string? AnonId { get; set; }
        public byte[] MillsToJoin { get; set; } = null!;
        public string? SuperShortId { get; set; }
        public string? GroupType { get; set; }
        public string? ExInfo { get; set; }
        public long? MovedToCommunityMember { get; set; }
        public long? IsFolded { get; set; }
        public long? IsPublic { get; set; }
        public long? IsPrivate { get; set; }
        public long? IsInvisibleFriend { get; set; }
    }
}
