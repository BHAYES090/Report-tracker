using System;
using System.Collections.Generic;
using System.Text;
using TRACKERLIBRARY.Models;

namespace TRACKERLIBRARY
{
    public class INTERREPORT
    {
        List<INTERREPORTMODEL> ReportTracker { get; set; } = new List<INTERREPORTMODEL>();
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public int CreateDate { get; set; }
    }
}
