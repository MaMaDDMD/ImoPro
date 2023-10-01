using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Sticker
    {
        public long Id { get; set; }
        public string StickerId { get; set; } = null!;
        public string? Imdata { get; set; }
        public string? PackId { get; set; }
        public long? Timestamp { get; set; }
        public long? Count { get; set; }
        public string? PackType { get; set; }
    }
}
