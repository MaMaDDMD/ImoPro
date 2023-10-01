using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class NewContact
    {
        public string Buid { get; set; } = null!;
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public long Timestamp { get; set; }
        public long Type { get; set; }
        public long Read { get; set; }
    }
}
