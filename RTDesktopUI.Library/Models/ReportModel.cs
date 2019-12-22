using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.Models
{
    public class ReportModel
    {
        //List<ReportModel> ReportTracker { get; set; } = new List<ReportModel>();
        public int Id { get; set; }
        public string UserNameEmailAddress { get; set; }
        public string CommentBox { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        // Testing purpose

        //public string returnValues()
        //{
        //    string returnval;

        //    returnval = UserNameEmailAddress + CommentBox + PhoneNumber;

        //    return returnval;
        //}

        //public ReportModel(int Id, string UserNameEmailAddress, string CommentBox, string PhoneNumber, string CreateDate)
        //{

        //}
    }
}
