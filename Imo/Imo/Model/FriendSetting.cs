using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class FriendSetting
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public long? CallMuted { get; set; }
        public long? ChatColor { get; set; }
        public string? Display { get; set; }
        public long? StoryMuted { get; set; }
        public string? ChatColor2 { get; set; }
        public string? ChatBackground { get; set; }
    }
}
