using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ChannelPostDetail
    {
        public long Id { get; set; }
        public string PostId { get; set; } = null!;
        public string ChannelId { get; set; } = null!;
        public long FavoriteNum { get; set; }
        public long ViewNum { get; set; }
        public long? HasFavorite { get; set; }
        public long UpdateTime { get; set; }
        public string? SourceChannelId { get; set; }
        public string? SourcePostId { get; set; }
    }
}
