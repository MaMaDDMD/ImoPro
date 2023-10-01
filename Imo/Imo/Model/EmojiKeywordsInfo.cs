using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class EmojiKeywordsInfo
    {
        public long Id { get; set; }
        public string LangCode { get; set; } = null!;
        public long? ServerTs { get; set; }
        public long? UpdateTs { get; set; }
    }
}
