using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class AccountType
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public long? AccountType1 { get; set; }
    }
}
