using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class FavoriteExpression
    {
        public long Id { get; set; }
        public string FavoriteId { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Object { get; set; } = null!;
        public long FavoriteTime { get; set; }
    }
}
