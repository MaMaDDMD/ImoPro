using System;
using System.Collections.Generic;

namespace Imo.Model
{
    public partial class FileTransfer
    {
        public long Id { get; set; }
        public string Taskid { get; set; } = null!;
        public string Buids { get; set; } = null!;
        public long Timestamp { get; set; }
        public string Filepath { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public long Filesize { get; set; }
        public string? Sha1sum { get; set; }
        public string? Ext { get; set; }
        public string? Url { get; set; }
        public long Progress { get; set; }
        public long Status { get; set; }
        public long Errorcode { get; set; }
        public long Type { get; set; }
        public string? ExtData { get; set; }
        public long DownType { get; set; }
        public long UploadType { get; set; }
        public long TaskPriority { get; set; }
    }
}
