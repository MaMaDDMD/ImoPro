using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class RecommendPhonebookContact
    {
        public string AnonId { get; set; } = null!;
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public string? Phone { get; set; }
        public string? PhonebookName { get; set; }
        public long Timestamp { get; set; }
    }
}
