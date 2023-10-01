using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Channel
    {
        public long Id { get; set; }
        public string ChannelId { get; set; } = null!;
        public string? ChannelType { get; set; }
        public string? Icon { get; set; }
        public string Display { get; set; } = null!;
        public long IsMuted { get; set; }
        public long UnsubscribeEnabled { get; set; }
        public long ShareEnabled { get; set; }
        public string? CertificationId { get; set; }
        public long IsFolded { get; set; }
        public long IsSubscribe { get; set; }
        public long IsBlocked { get; set; }
        public string? ShareId { get; set; }
    }
}
