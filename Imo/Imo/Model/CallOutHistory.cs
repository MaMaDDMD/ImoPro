using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class CallOutHistory
    {
        public long Id { get; set; }
        public long Timestamp { get; set; }
        public string Name { get; set; } = null!;
        public string? Uid { get; set; }
        public string? ContactId { get; set; }
        public string Phone { get; set; } = null!;
        public string Normalized { get; set; } = null!;
        public string? Stat { get; set; }
        public string? Time { get; set; }
    }
}
