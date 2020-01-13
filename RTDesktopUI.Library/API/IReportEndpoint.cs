using System;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.API
{
    public interface IReportEndpoint
    {
        Task PostReport(string CreateDate, string UserNameEmailAddress, string PhoneNumber, string CommentBox);
    }
}