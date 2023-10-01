using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ChannelCertInfo
    {
        public long Id { get; set; }
        public string CertificationId { get; set; } = null!;
        public string JsonResult { get; set; } = null!;
    }
}
