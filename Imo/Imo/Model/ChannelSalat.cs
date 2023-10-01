using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ChannelSalat
    {
        public long Id { get; set; }
        public string SeqId { get; set; } = null!;
        public string ChannelId { get; set; } = null!;
        public string? ChannelType { get; set; }
        public string? Icon { get; set; }
        public string PostType { get; set; } = null!;
        public long? State { get; set; }
        public string RecordDate { get; set; } = null!;
        public long? RecordCount { get; set; }
        public string RecordCity { get; set; } = null!;
    }
}
