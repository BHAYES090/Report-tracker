using System;
using System.Collections.Generic;
using System.Text;

namespace TRACKERLIBRARY.Models
{
    public class INTERREPORTMODEL
    {
        List<INTERREPORTMODEL> ReportTracker { get; set; } = new List<INTERREPORTMODEL>();
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public int CreateDate { get; set; }

        //TODO- CHECK TO SEE IF THIS IS THE RIGHT SOLUTION FOR model.id
        public int id { get; internal set; }
    }
}
