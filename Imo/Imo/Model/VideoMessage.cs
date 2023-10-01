using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class VideoMessage
    {
        public long Id { get; set; }
        public long ViewType { get; set; }
        public string Buid { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Icon { get; set; }
        public string? Author { get; set; }
        public string? AuthorAlias { get; set; }
        public string? AuthorIcon { get; set; }
        public string? Imdata { get; set; }
        public string? LastMessage { get; set; }
        public long? Timestamp { get; set; }
        public long? MessageIndex { get; set; }
        public long MessageType { get; set; }
        public long MessageState { get; set; }
        public long MessageRead { get; set; }
    }
}
