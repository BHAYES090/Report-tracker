using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.Models
{
    public interface IReportModel
    {
        int Id { get; set; }
        string CreateDate { get; set; }
        string UserNameEmailAddress { get; set; }
        string PhoneNumber { get; set; }
        string CommentBox { get; set; }
    }
}
