using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class ImoPhonebook
    {
        public long Id { get; set; }
        public string Phone { get; set; } = null!;
        public string Normalized { get; set; } = null!;
        public string? Name { get; set; }
        public string? Uid { get; set; }
        public long? IncomingCalls { get; set; }
        public long? OutgoingCalls { get; set; }
        public long? TimeIncoming { get; set; }
        public long? TimeOutgoing { get; set; }
        public long? NumDaysCalls { get; set; }
        public long? IncomingSms { get; set; }
        public long? OutgoingSms { get; set; }
        public long? NumDaysSms { get; set; }
        public long? TimesContacted { get; set; }
        public long? Starred { get; set; }
        public long? Score { get; set; }
        public long? NewScore { get; set; }
        public long? LastContacted { get; set; }
        public long? Card { get; set; }
        public string? InviteStatus { get; set; }
    }
}
