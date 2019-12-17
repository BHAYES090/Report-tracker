using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrackerLibrary2
{
    public class INTERREPORTMODEL2
    {
        List<INTERREPORTMODEL2> ReportTracker { get; set; } = new List<INTERREPORTMODEL2>();
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] ScreenShot { get; set; }
        public int Id { get; set; }

        
    }
}
