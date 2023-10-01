using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class EmojiKeyword
    {
        public long Id { get; set; }
        public string LangCode { get; set; } = null!;
        public string Keyword { get; set; } = null!;
        public string Emoji { get; set; } = null!;
    }
}
