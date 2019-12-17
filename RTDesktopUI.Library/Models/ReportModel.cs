using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.Models
{
    public class ReportModel
    {
        public string UserNameEmailAddress { get; set; }
        public string CommentBox { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
