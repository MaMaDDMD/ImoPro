using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Relationship
    {
        public long Id { get; set; }
        public string RelId { get; set; } = null!;
        public string? TinyProfile { get; set; }
        public string? SourceType { get; set; }
        public string? Source { get; set; }
        public string? RequestStatus { get; set; }
        public string? Request { get; set; }
        public long Timestamp { get; set; }
        public long HasReply { get; set; }
        public long HasTipLimit { get; set; }
        public long IsIgnore { get; set; }
        public string? AnonId { get; set; }
    }
}
