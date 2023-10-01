using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class HdVideo2
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public long IsHdVideoCapable { get; set; }
        public long IsHdVideo { get; set; }
        public long? Timestamp { get; set; }
    }
}
