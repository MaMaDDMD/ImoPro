using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class CallTimestamp
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public long Time { get; set; }
    }
}
