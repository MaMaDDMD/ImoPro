using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class SecretChat
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Icon { get; set; }
        public string? LastMessage { get; set; }
        public long Timestamp { get; set; }
        public string? DeviceInfo { get; set; }
    }
}
