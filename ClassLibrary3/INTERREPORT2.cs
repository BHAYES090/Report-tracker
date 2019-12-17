using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrackerLibrary2
{
    public class INTERREPORT2
    {
        List<INTERREPORT2> ReportTracker { get; set; } = new List<INTERREPORT2>();
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public string CreateDate { get; set; }
        public Image ScreenShot { get; set; }
        public int Id { get; set; }
    }
}
