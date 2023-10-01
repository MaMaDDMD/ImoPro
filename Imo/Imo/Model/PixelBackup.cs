using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class PixelBackup
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string ViewType { get; set; } = null!;
        public long Timestamp { get; set; }
        public long MessageState { get; set; }
        public string? ObjectId { get; set; }
    }
}
