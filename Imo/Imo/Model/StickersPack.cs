using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class StickersPack
    {
        public long Id { get; set; }
        public string PackId { get; set; } = null!;
        public string? Name { get; set; }
        public string? ProductId { get; set; }
        public long? Purchased { get; set; }
        public string? Author { get; set; }
        public long? NumStickers { get; set; }
        public long? Price { get; set; }
        public string? Description { get; set; }
        public long? InUse { get; set; }
        public long? DownloadTime { get; set; }
        public long Scene { get; set; }
        public string? PackType { get; set; }
        public string? TitleImg { get; set; }
        public string? TabImg { get; set; }
        public long? IsDefault { get; set; }
        public long? IsPromote { get; set; }
    }
}
