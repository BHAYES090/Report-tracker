using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDataManager.Library.Models
{
    public class ReportModel
    {
        public string Id { get; set; }
        public string UserNameEmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("MM DD YYYY");
    }
}
