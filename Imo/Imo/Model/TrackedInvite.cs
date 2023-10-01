using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class TrackedInvite
    {
        public long Id { get; set; }
        public string Phone { get; set; } = null!;
        public long Time { get; set; }
        public long Success { get; set; }
    }
}
