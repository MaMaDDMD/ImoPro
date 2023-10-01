using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class FileAssistant
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string? Gid { get; set; }
        public string AliasSl { get; set; } = null!;
        public string Display { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? NoteName { get; set; }
        public string? Icon { get; set; }
        public long? Starred { get; set; }
        public long? IsMuted { get; set; }
        public long? TimesContacted { get; set; }
        public string? Type { get; set; }
        public byte[] LastActiveTimes { get; set; } = null!;
        public long? Score { get; set; }
        public string? InviteStatus { get; set; }
        public long? BubbleStatus { get; set; }
        public long? IsPrivate { get; set; }
        public long? IsInvisibleFriend { get; set; }
        public string? IconStyle { get; set; }
    }
}
