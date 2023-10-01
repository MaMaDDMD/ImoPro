using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class PhonebookEntry
    {
        public long Id { get; set; }
        public string Phone { get; set; } = null!;
        public string NormalizedPhone { get; set; } = null!;
        public string? Name { get; set; }
        public long? Card { get; set; }
        public long? DataVersion { get; set; }
        public long? ContactId { get; set; }
    }
}
