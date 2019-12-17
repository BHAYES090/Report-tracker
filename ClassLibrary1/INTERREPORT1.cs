using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ClassLibrary1
{
    public class INTERREPORT1
    {
        List<INTERREPORTMODEL1> ReportTracker { get; set; } = new List<INTERREPORTMODEL1>();
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public int CreateDate { get; set; }
    }
}
}
