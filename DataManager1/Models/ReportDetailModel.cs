using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataManager1.Models
{
    public class ReportDetailModel
    {
        public int Id { get; set; }
        public string UserNameEmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}