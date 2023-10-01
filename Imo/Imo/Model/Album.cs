using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Album
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string? Imdata { get; set; }
        public string? Album1 { get; set; }
        public string? OriginalId { get; set; }
        public long Timestamp { get; set; }
        public string? ObjectId { get; set; }
        public long AlbumsNumbers { get; set; }
    }
}
