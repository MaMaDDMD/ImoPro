using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class PrivacyEncryptDevice
    {
        public string Uid { get; set; } = null!;
        public string Udid { get; set; } = null!;
        public string Eid { get; set; } = null!;
        public string? DeviceInfo { get; set; }
        public long? EncryptVersion { get; set; }
        public string? PublicIdentifyKey { get; set; }
        public long? PublicSignedPreId { get; set; }
        public string? PublicSignedPreKey { get; set; }
        public long? OneTimePreId { get; set; }
        public string? OneTimePreKey { get; set; }
        public long OfflineTs { get; set; }
    }
}
