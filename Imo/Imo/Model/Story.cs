using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class Story
    {
        public long Id { get; set; }
        public string Buid { get; set; } = null!;
        public long MessageRead { get; set; }
        public long ViewType { get; set; }
        public long Timestamp { get; set; }
        public long MessageLiked { get; set; }
        public long StoryFriendsLiked { get; set; }
        public long IsPublic { get; set; }
        public string? Imdata { get; set; }
        public string? OriginalId { get; set; }
        public long? NumTries { get; set; }
        public long? GroupNum { get; set; }
        public long? StoryPushNotify { get; set; }
        public double? StoryIntimacyScore { get; set; }
        public string? ObjectId { get; set; }
        public string? StoryAlbumList { get; set; }
        public string? RecommendInfo { get; set; }
    }
}
