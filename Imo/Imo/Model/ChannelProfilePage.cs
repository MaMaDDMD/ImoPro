using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ChannelProfilePage
    {
        public long Id { get; set; }
        public string ChannelId { get; set; } = null!;
        public string JsonResult { get; set; } = null!;
    }
}
