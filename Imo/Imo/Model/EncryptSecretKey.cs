using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class EncryptSecretKey
    {
        public string X3dhKey { get; set; } = null!;
        public string? Value { get; set; }
    }
}
