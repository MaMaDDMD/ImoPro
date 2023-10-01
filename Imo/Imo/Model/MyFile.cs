using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class MyFile
    {
        public long Id { get; set; }
        public string UniqueId { get; set; } = null!;
        public string? FileId { get; set; }
        public long? ImRowId { get; set; }
        public string Uid { get; set; } = null!;
        public string Buid { get; set; } = null!;
        public long MessageTs { get; set; }
        public long State { get; set; }
        public long Score { get; set; }
        public string Imdata { get; set; } = null!;
        public long IsSent { get; set; }
        public long IsLocal { get; set; }
        public string? Alias { get; set; }
        public string? TaskId { get; set; }
        public string? Url { get; set; }
    }
}
