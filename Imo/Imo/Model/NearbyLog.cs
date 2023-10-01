using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class NearbyLog
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string? Thumb { get; set; }
        public long Filesize { get; set; }
        public long Payloadid { get; set; }
        public long Type { get; set; }
        public long Done { get; set; }
        public long Time { get; set; }
    }
}
