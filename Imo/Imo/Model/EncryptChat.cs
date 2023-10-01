using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class EncryptChat
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public long LastSeq { get; set; }
        public long LastTimestamp { get; set; }
    }
}
