using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class CachedUpload
    {
        public long Id { get; set; }
        public string Md5Hash { get; set; } = null!;
        public string ServerId { get; set; } = null!;
        public long? UploadTimestamp { get; set; }
    }
}
