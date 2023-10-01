using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class SecretKey
    {
        public long Id { get; set; }
        public string DeviceId { get; set; } = null!;
        public string? X3dhKey { get; set; }
        public string? Value { get; set; }
    }
}
