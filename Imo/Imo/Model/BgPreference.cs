using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class BgPreference
    {
        public long Id { get; set; }
        public string Bgid { get; set; } = null!;
        public long AudioMessageOnly { get; set; }
        public long DisableGroupCardMessage { get; set; }
        public long DisableAudioMessage { get; set; }
        public long? DisableChannelMessage { get; set; }
    }
}
