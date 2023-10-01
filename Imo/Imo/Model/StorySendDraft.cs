using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class StorySendDraft
    {
        public long Id { get; set; }
        public string DraftId { get; set; } = null!;
        public string Buid { get; set; } = null!;
        public long State { get; set; }
        public long? Timestamp { get; set; }
        public string? Path { get; set; }
        public string? OverlayPath { get; set; }
        public string? Imdata { get; set; }
        public string? Url { get; set; }
        public string ViewType { get; set; } = null!;
        public string Level { get; set; } = null!;
        public string? Source { get; set; }
        public long? SendStory { get; set; }
        public string? GroupGid { get; set; }
        public long? IsFront { get; set; }
        public long? MessageRead { get; set; }
        public long? IsForFeed { get; set; }
        public string? StoryConfig { get; set; }
    }
}
