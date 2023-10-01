using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Account
    {
        public long Id { get; set; }
        public string Uid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Iat { get; set; } = null!;
        public string? Phone { get; set; }
        public string? PhoneCc { get; set; }
        public string? Icon { get; set; }
    }
}
