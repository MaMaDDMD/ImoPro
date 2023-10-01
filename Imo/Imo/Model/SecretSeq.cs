using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class SecretSeq
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string DeviceId { get; set; } = null!;
        public long? LastSeq { get; set; }
    }
}
