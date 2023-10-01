using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class CallsOnly
    {
        public long Id { get; set; }
        public string ChatType { get; set; } = null!;
        public string CallType { get; set; } = null!;
        public string Buid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Imdata { get; set; }
        public string? Icon { get; set; }
        public string? LastMessage { get; set; }
        public long Timestamp { get; set; }
        public long? Duration { get; set; }
        public string? State { get; set; }
    }
}
