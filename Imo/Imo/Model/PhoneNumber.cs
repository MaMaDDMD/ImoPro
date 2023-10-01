using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class PhoneNumber
    {
        public long Id { get; set; }
        public string Uid { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
