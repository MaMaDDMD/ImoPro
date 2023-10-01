using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class BubbleInfo
    {
        public long Id { get; set; }
        public string BubbleId { get; set; } = null!;
        public string Bgid { get; set; } = null!;
        public string PreviewImage { get; set; } = null!;
        public string ReceiveImage { get; set; } = null!;
        public string SendImage { get; set; } = null!;
        public string LabelImage { get; set; } = null!;
        public string TextColor { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BackgroundColor { get; set; } = null!;
        public string Tip { get; set; } = null!;
        public long Type { get; set; }
        public string? TopFloorTextColor { get; set; }
        public string? TopFloorMaskTransparency { get; set; }
        public string? BubbleType { get; set; }
    }
}
