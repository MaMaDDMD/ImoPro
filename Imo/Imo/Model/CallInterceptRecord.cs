using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class CallInterceptRecord
    {
        public long Id { get; set; }
        public string? ChatType { get; set; }
        public string? Alias { get; set; }
        public string? Buid { get; set; }
        public string? Icon { get; set; }
        public string? Timestamp { get; set; }
    }
}
